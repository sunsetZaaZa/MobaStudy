using System.Data;

using Npgsql;
using NpgsqlTypes;

using MobaGains.Rigging.Database.Database;

namespace MobaGains.Rigging.Database.Repos;

public class ChampionRepo
{
    private DatabaseContext _activeDatabase { get; set; }
    public ChampionRepo(DatabaseContext database)
    {
        _activeDatabase = database;
    }

}
