using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class Leveling
{
    public Leveling(int championId, int patchIndexer, bool cooldown, bool cost, KeyActivationIndexer? keyActivation, List<int> values, string unit)
    {
        this.championId = championId;
        this.patchIndexer = patchIndexer;
        this.cooldown = cooldown;
        this.cost = cost;
        this.keyActivation = keyActivation;
        this.values = values;
        this.unit = unit;
    }

    public int championId { get; set; } //Primary Key
    public int patchIndexer { get; set; }
    public bool cooldown { get; set; }
    public bool cost { get; set; }
    public KeyActivationIndexer? keyActivation { get; set; }
    public List<int> values { get; set; }
    public string unit { get; set; }
}
