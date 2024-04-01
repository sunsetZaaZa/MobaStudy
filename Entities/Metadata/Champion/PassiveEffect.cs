namespace MobaGains.Entities.Metadata.Champion;

public class PassiveEffect
{
    public PassiveEffect(int indexer, int championId, string description)
    {
        this.indexer = indexer;
        this.championId = championId;
        this.description = description;
    }

    public int indexer { get; set; } //Primary Key
    public int championId { get; set; } //Indexed By
    public string description { get; set; }
}
