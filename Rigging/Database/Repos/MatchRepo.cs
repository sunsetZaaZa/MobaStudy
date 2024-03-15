using System.Data;

using Npgsql;
using NpgsqlTypes;

namespace MobaGains.Rigging.Database.Repos;

public class MatchRepo
{
    private DatabaseContext _activeDatabase { get; set; }
    public MatchRepo(DatabaseContext database)
    {
        _activeDatabase = database;
    }
}
