namespace MobaGains.Entities.LegendsDto;

public class ChampionInfo
{
    public ChampionInfo(long id, DateTime start, DateTime? end, string hashValue, int maxNewPlayerLevel, List<int> freeChampionIdsForNewPlayers, List<int> freeChampionsId)
    {
        this.id = id;
        this.start = start;
        this.end = end;
        this.hashValue = hashValue;
        this.maxNewPlayerLevel = maxNewPlayerLevel;
        this.freeChampionIdsForNewPlayers = freeChampionIdsForNewPlayers;
        this.freeChampionsId = freeChampionsId;
    }

    public long id { get; set; }
    public DateTime start { get; set; }
    public DateTime? end { get; set; }
    public string hashValue { get; set; }
    public int maxNewPlayerLevel { get; set; }
    public List<int> freeChampionIdsForNewPlayers { get; set; }
    public List<int> freeChampionsId { get; set; }
}
