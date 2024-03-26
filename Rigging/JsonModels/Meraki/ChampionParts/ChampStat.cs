namespace MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

public struct ChampStat
{
    public ChampStat(float flat, float percent, float perLevel, float percentPerLevel)
    {
        this.flat = flat;
        this.percent = percent;
        this.perLevel = perLevel;
        this.percentPerLevel = percentPerLevel;
    }

    public float flat { get; set; }
    public float percent { get; set; }
    public float perLevel { get; set; }
    public float percentPerLevel { get; set; }
}
