using System.Management.Automation;
using System.Text.RegularExpressions;

using MobaGains.Rigging.LCU.DataTypes;

namespace MobaGains.Rigging.LCU;

public class RiotConnector
{
    private static string testPattern = "\"--install-directory=(.*?s)\"";

    public Lockfile? AcquireLockFile(string applicationName)
    {
        string PSCommand = "WMIC PROCESS WHERE \"name='" + applicationName + "'\" GET commandline";
        string? fullString = null;
        Lockfile? locks = null;

        using (var ps = PowerShell.Create())
        {
            try
            {
                var results = ps.AddScript(PSCommand).Invoke();
                if (results.Count > 0)
                {
                    string lookSee;
                    foreach (var result in results)
                    {
                        lookSee = result.ToString();
                        if (lookSee.Contains("LeagueClientUx.exe"))
                        {
                            fullString = lookSee;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return locks;
            }
        }

        if (fullString != null)
        {
            Match result = Regex.Match(fullString, testPattern);
            fullString = result.Groups[1].Value;

            string lockfilePath = fullString + Path.DirectorySeparatorChar + "lockfile";
            string lockfileContents = File.ReadAllText(lockfilePath);
            string[] lockfileParts = lockfileContents.Split(":");
            locks = new Lockfile("riot", lockfileParts[3], "127.0.0.1", Int32.Parse(lockfileParts[2]), lockfileParts[4], Int32.Parse(lockfileParts[1]), lockfileParts[0]);
        }

        return locks;
    }
}
