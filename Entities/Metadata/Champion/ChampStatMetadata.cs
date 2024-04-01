using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampStatMetadata
{
    public ChampStatMetadata(int indexer, int championId, ChampStatTypeIndexer statType, float flat, float percent, 
                                float perLevel, float percentPerLevel)
    {
        this.indexer = indexer;
        this.championId = championId;
        this.statType = statType;
        this.flat = flat;
        this.percent = percent;
        this.perLevel = perLevel;
        this.percentPerLevel = percentPerLevel;
    }

    public int indexer { get; set; } //Primary Key
    public int championId { get; set; } //Indexed By
    public ChampStatTypeIndexer statType { get; set; }
    public float flat { get; set; }
    public float percent { get; set; }
    public float perLevel { get; set; }
    public float percentPerLevel { get; set; }
}
