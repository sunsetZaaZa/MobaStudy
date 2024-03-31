using MobaGains.Entities.LegendsDto.Enums;

namespace MobaGains.Entities.Gameplay;

public class GameHistory
{
    public GameHistory(Guid indexer, string matchId, Maps mapId, GameMode gameMode, Guid tailoredLoadoutGuid)
    {
        this.indexer = indexer;
        this.matchId = matchId;
        this.mapId = mapId;
        this.gameMode = gameMode;
        this.tailoredLoadoutGuid = tailoredLoadoutGuid;
    }

    public Guid indexer { get; set; }
    public string matchId { get; set; }
    public Maps mapId { get; set; }
    public GameMode gameMode { get; set; }
    public int championId { get; set; }
    public bool win { get; set; }
    public Guid tailoredLoadoutGuid { get; set; }
}
