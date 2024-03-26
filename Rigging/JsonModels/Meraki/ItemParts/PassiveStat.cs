namespace MobaGains.Rigging.JsonModels.Meraki.ItemParts;

public class PassiveStat
{
    public bool unique { get; set; }
    public bool mythic { get; set; }
    public string name { get; set; }
    public string effects { get; set; }
    public int range { get; set; }
    public string cooldown { get; set; }
    public StatsBreakdown stats { get; set; }
}
