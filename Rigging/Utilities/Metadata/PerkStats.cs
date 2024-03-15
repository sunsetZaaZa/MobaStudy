namespace MobaGains.Rigging.Utilities.Metadata;

public class PerkStats
{
    public PerkStats(string id, string name, string description)
    {
        this.id = id;
        this.name = name;
        this.description = description;
    }

    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
}
