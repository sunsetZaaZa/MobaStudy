namespace MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

public class AbilityLevel
{
    public AbilityLevel(string attribute, List<SubDetails> modifiers)
    {
        this.attribute = attribute;
        this.modifiers = modifiers;
    }

    public string attribute { get; set; }
    public List<SubDetails> modifiers { get; set; } 
}
