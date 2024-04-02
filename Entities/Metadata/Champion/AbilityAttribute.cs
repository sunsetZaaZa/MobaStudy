using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class AbilityAttribute
{
    public AbilityAttribute(int championId, KeyActivationIndexer index, int ordering, string attribute, List<Leveling> levels)
    {
        this.championId = championId;
        this.index = index;
        this.ordering = ordering;
        this.attribute = attribute;
        this.levels = levels;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer index { get; set; } //Primary Key
    public int ordering { get; set; } //Primary Key
    public string attribute {  get; set; }
    public List<Leveling> levels { get; set; }
}
