namespace MobaGains.Rigging.LCU.DataTypes;

public record Lockfile
{
    public Lockfile(string username, string password, string address, int port, string protocol, int PID, string processName )
    {
        this.password = password;
        this.address = address;
        this.port = port;
        this.protocol = protocol;
        this.PID = PID;
        this.processName = processName;
    }

    public string username { get; set; } = "riot";
    public string password { get; set; }
    public string address { get; set; } = "127.0.0.1";
    public int port { get; set; }
    public string protocol { get; set; }
    public int PID { get; set; }
    public string processName { get; set; }
}
