using System.Diagnostics.CodeAnalysis;

namespace MobaGains.Rigging.Configs;

public class LCUConfig
{
    [SetsRequiredMembers]
    public LCUConfig(string riotApplicationName, string username, string address)
    {
        this.riotApplicationName = riotApplicationName;
        this.username = username;
        this.address = address;
    }

    public required string riotApplicationName { get; set; }
    public required string username { get; set; }
    public required string address { get; set; }
}
