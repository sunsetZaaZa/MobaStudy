using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampionPassive
{
    public ChampionPassive(string description, List<ChampionAbilityEffect> effects)
    {
        this.description = description;
        this.effects = effects;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer index { get; set; } //Primary Key
    public string description { get; set; }
    public List<ChampionAbilityEffect> effects { get; set; }
}