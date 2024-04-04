using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampionPassive
{
    public ChampionPassive(int championId, KeyActivationIndexer index, int patchIndexer, string description, List<ChampionAbilityEffect> effects)
    {
        this.championId = championId;
        this.index = index;
        this.patchIndexer = patchIndexer;
        this.description = description;
        this.effects = effects;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer index { get; set; } //Primary Key
    public int patchIndexer { get; set; } 
    public string description { get; set; }
    public List<ChampionAbilityEffect> effects { get; set; }
}