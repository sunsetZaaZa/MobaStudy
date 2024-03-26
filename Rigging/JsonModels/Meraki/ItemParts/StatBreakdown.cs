namespace MobaGains.Rigging.JsonModels.Meraki.ItemParts;

public struct StatBreakdown
{
    public StatBreakdown(float flat, float percent, float perLevel, float percentPerLevel, float percentBase, float percentBonus)
    {
        this.flat = flat;
        this.percent = percent;
        this.perLevel = perLevel;
        this.percentPerLevel = percentPerLevel;
        this.percentBase = percentBase;
        this.percentBonus = percentBonus;
    }

    public float flat { get; set; }
    public float percent { get; set; }
    public float perLevel { get; set; }
    public float percentPerLevel { get; set; }
    public float percentBase { get; set; }
    public float percentBonus { get; set; }
}
