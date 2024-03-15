using System.Data;

using Npgsql;
using NpgsqlTypes;

namespace MobaGains.Rigging.Database.Repos;

public class SettingsRepo
{
    private DatabaseContext _activeDatabase { get; set; }
    public SettingsRepo(DatabaseContext database)
    {
        _activeDatabase = database;
    }
}
