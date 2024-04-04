using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampStatMetadata
{
    public ChampStatMetadata(int championId, ChampStatTypeIndexer statType, int patchIndexer, float flat, float percent, float perLevel, float percentPerLevel)
    {
        this.championId = championId;
        this.statType = statType;
        this.patchIndexer = patchIndexer;
        this.flat = flat;
        this.percent = percent;
        this.perLevel = perLevel;
        this.percentPerLevel = percentPerLevel;
    }

    public int championId { get; set; } //Primary Key
    public ChampStatTypeIndexer statType { get; set; } //Primary Key
    public int patchIndexer { get; set; }
    public float flat { get; set; }
    public float percent { get; set; }
    public float perLevel { get; set; }
    public float percentPerLevel { get; set; }
}
