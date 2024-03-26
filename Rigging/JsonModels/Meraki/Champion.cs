using MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

namespace MobaGains.Rigging.JsonModels.Meraki;

public class AbilityList
{
    public List<AbilityBreakdown> P { get; set; }
    public List<AbilityBreakdown> Q { get; set; }
    public List<AbilityBreakdown> W { get; set; }
    public List<AbilityBreakdown> E { get; set; }
    public List<AbilityBreakdown> R { get; set; }
}

public class Champion
{
    public Champion(int id, string key, string name, string title, string fullName, string icon, string resource, string attackType, string adaptiveType, ChampStats stats,
                    List<string> roles, AttributeRates attributeRatings, AbilityList abilities, string releaseDate, string releasePatch, string patchLastChanged)
    {
        this.id = id;
        this.key = key;
        this.name = name;
        this.title = title;
        this.fullName = fullName;
        this.icon = icon;
        this.resource = resource;
        this.attackType = attackType;
        this.adaptiveType = adaptiveType;
        this.stats = stats;
        this.roles = roles;
        this.attributeRatings = attributeRatings;
        this.abilities = abilities;
        this.releaseDate = releaseDate;
        this.releasePatch = releasePatch;
        this.patchLastChanged = patchLastChanged;
    }

    public int id { get; set; }
    public string key { get; set; }
    public string name { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public string icon { get; set; }
    public string resource { get; set; }
    public string attackType { get; set; }
    public string adaptiveType { get; set; }
    public ChampStats stats { get; set; }
    public List<string> roles { get; set; }
    public AttributeRates attributeRatings { get; set; }
    public AbilityList abilities { get; set; }
    public string releaseDate { get; set; }
    public string releasePatch { get; set; }
    public string patchLastChanged { get; set; }
}
