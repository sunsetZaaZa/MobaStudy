using System.Data;

using Npgsql;
using NpgsqlTypes;

namespace MobaGains.Rigging.Database.Repos;

public class ChampionRepo
{
    private DatabaseContext _activeDatabase { get; set; }
    public ChampionRepo(DatabaseContext database)
    {
        _activeDatabase = database;
    }

}
