using MobaGains.Rigging.Database.Database;

namespace MobaGains.Rigging.Database.Repos;

public interface IGameMetadataRepo
{

}

public class GameMetadataRepo
{
    private DatabaseContext _activeDatabase { get; set; }
    public GameMetadataRepo(DatabaseContext database)
    {
        _activeDatabase = database;
    }
}
