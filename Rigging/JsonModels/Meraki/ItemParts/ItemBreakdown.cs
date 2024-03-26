namespace MobaGains.Rigging.JsonModels.Meraki.ItemParts;

public class ItemBreakdown
{
    public string name { get; set; }
    public int id { get; set; }
    public int tier { get; set; }
    public List<string> rank { get; set; }
    public List<int> buildsFrom { get; set; }
    public List<int> buildInto { get; set; }
    public int specialRecipe { get; set; }
    public bool noEffects { get; set; }
    public bool removed { get; set; }
    public string requiredChampion { get; set; }
    public string requiredAlly { get; set; }
    public string icon { get; set; }
    public string simpleDescription { get; set; }
    public List<string> nicknames { get; set; }
    public List<PassiveStat> passives { get; set; }
    public List<ActiveStat> active { get; set; }
    public StatsBreakdown stats { get; set; }
    public ShopBreakdown shop { get; set; }
    public bool iconOverlay { get; set; }
}
