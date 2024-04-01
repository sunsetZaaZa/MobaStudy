namespace MobaGains.Entities.Metadata.Champion;

public class ChampionPassive
{
    public ChampionPassive(int indexer, int championId, string name, string description, List<string> effects)
    {
        this.indexer = indexer;
        this.championId = championId;
        this.name = name;
        this.description = description;
        this.effects = effects;
    }

    public int indexer { get; set; }
    public int championId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public List<string> effects { get; set; }
}