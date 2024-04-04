using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampionAbilityEffect
{
    public ChampionAbilityEffect(int championId, KeyActivationIndexer index, int ordering, int patchVesion, string description, List<AbilityAttribute> detail)
    {
        this.championId = championId;
        this.index = index;
        this.ordering = ordering;
        this.patchVersion = patchVersion;
        this.description = description;
        this.detail = detail;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer index { get; set; } //Primary Key
    public int ordering { get; set; } //Primary Key
    public int patchVersion { get; set; }
    public string description { get; set; }
    public List<AbilityAttribute> detail { get; set; }
}
