using Microsoft.Extensions.Options;
using MobaGains.Rigging.Configs;
using Npgsql;

namespace MobaGains.Rigging.Database.Database;

public class DatabaseContext
{
    protected readonly DatabaseConfig _dbSettings;
    protected readonly NpgsqlDataSource _databaseInstance;

    public DatabaseContext(IOptions<DatabaseConfig> dbSettings)
    {
        _dbSettings = dbSettings.Value;

        var connectionString = $"Host={_dbSettings.servers}; Database={_dbSettings.database}; Username={_dbSettings.userId}; Password={_dbSettings.password};";
        NpgsqlDataSourceBuilder connection = new NpgsqlDataSourceBuilder(connectionString);
        this._databaseInstance = connection.Build();
    }

    public async Task<NpgsqlConnection> CreateConnection()
    {
        return await _databaseInstance.OpenConnectionAsync();
    }
}