using System.Data;

using Npgsql;
using NpgsqlTypes;

namespace MobaGains.Rigging.Database.Repos;

public class ItemRepo
{
    private DatabaseContext _activeDatabase { get; set; }
    public ItemRepo(DatabaseContext database)
    {
        _activeDatabase = database;
    }
}
