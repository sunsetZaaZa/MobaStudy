namespace MobaGains.Rigging.JsonModels.Meraki.ItemParts;

public class ActiveStat
{
    public ActiveStat(bool unique, string name, string effects, int range, int cooldown)
    {
        this.unique = unique;
        this.name = name;
        this.effects = effects;
        this.range = range;
        this.cooldown = cooldown;
    }

    public bool unique { get; set; }
    public string name { get; set; }
    public string effects { get; set; }
    public int range { get; set; }
    public int cooldown { get; set; }
}
