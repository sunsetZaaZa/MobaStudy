using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class Leveling
{
    public Leveling(int championId, bool? cooldown, bool? cost, KeyActivationIndexer? keyActivation, List<int> values, List<AbilityUnitIndexer> units)
    {
        this.championId = championId;
        this.cooldown = cooldown;
        this.cost = cost;
        this.keyActivation = keyActivation;
        this.values = values;
        this.units = units;
    }

    public int championId { get; set; } //Primary Key
    public bool? cooldown { get; set; }
    public bool? cost { get; set; }
    public KeyActivationIndexer? keyActivation { get; set; }
    public List<int> values { get; set; }
    public List<AbilityUnitIndexer> units { get; set; }
}
