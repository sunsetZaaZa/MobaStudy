namespace MobaGains.Rigging.Utilities.Metadata;

public class ChampionSummary
{
    public ChampionSummary(int id, string name, string alias, string iconId, List<string> roles)
    {
        this.id = id;
        this.name = name;
        this.alias = alias;
        this.iconId = iconId;
        this.roles = roles;
    }

    public int id { get; set; }
    public string name { get; set; }
    public string alias { get; set; }
    public string iconId { get; set; }
    public List<string> roles { get; set; }
}
