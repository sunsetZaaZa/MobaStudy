using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Gameplay;

public class GameHistory
{
    public GameHistory(Guid indexer, string matchId, MapIndexer mapId, GameMode gameMode, int championId, bool win, Guid tailoredLoadoutGuid)
    {
        this.indexer = indexer;
        this.matchId = matchId;
        this.mapId = mapId;
        this.gameMode = gameMode;
        this.championId = championId;
        this.win = win;
        this.tailoredLoadoutGuid = tailoredLoadoutGuid;
    }

    public Guid indexer { get; set; }
    public string matchId { get; set; }
    public MapIndexer mapId { get; set; }
    public GameMode gameMode { get; set; }
    public int championId { get; set; }
    public bool win { get; set; }
    public Guid tailoredLoadoutGuid { get; set; }
}
