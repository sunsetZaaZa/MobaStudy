namespace MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

public class AbilityEffect
{
    public AbilityEffect(string description, List<AbilityLevel> leveling)
    {
        this.description = description;
        this.leveling = leveling;
    }

    public string description { get; set; }
    public List<AbilityLevel> leveling { get; set; }
}
