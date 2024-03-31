namespace MobaGains.Entities.Gameplay;

//TODO : look into ItemSets within game
public class GearLayout
{
    public GearLayout(Guid indexer, bool loadedInGame, string name, List<int> championId)
    {
        this.indexer = indexer;
        this.loadedInGame = loadedInGame;
        this.name = name;
        this.championId = championId;
    }

    public Guid indexer { get; set; }
    public bool loadedInGame { get; set; }
    public string name { get; set; }
    public List<int> championId { get; set; }
}
