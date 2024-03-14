using System.Diagnostics.CodeAnalysis;

namespace MobaGains.Rigging.Configs;

public class DatabaseConfig
{
    [SetsRequiredMembers]
    public DatabaseConfig(string servers, string database, string password, string userId)
    {
        this.servers = servers;
        this.database = database;
        this.password = password;
        this.userId = userId;
    }

    public required string servers { get; set; }
    public required string database { get; set; }
    public required string password { get; set; }
    public required string userId { get; set; }
}
