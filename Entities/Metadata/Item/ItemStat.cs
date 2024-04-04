using MobaGains.Rigging.Enum;

namespace MobaGains.Entities.Metadata.Item;

public class ItemStat
{
    public ItemStat(int itemId, StatAttribute attribute, int patchVersion, float modifyAmount, ScalingType scaling, ActivationType activateHow)
    {
        this.itemId = itemId;
        this.attribute = attribute;
        this.patchVersion = patchVersion;
        this.modifyAmount = modifyAmount;
        this.scaling = scaling;
        this.activateHow = activateHow;
    }

    public int itemId { get; set; }
    public StatAttribute attribute { get; set; }
    public int patchVersion { get; set; }
    public float modifyAmount { get; set; }
    public ScalingType scaling { get; set; }
    public ActivationType activateHow { get; set; }
}
