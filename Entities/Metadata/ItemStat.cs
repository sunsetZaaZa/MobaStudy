using MobaGains.Rigging.Enum;

namespace MobaGains.Entities.Metadata;

public class ItemStat
{
    public ItemStat(Guid marker, int itemId, float modifyAmount, StatAttribute attribute, ScalingType scaling, ActivationType activateHow)
    {
        this.marker = marker;
        this.itemId = itemId;
        this.modifyAmount = modifyAmount;
        this.attribute = attribute;
        this.scaling = scaling;
        this.activateHow = activateHow;
    }

    public Guid marker { get; set; }
    public int itemId { get; set; }
    public float modifyAmount { get; set; }
    public StatAttribute attribute { get; set; }
    public ScalingType scaling { get; set; }
    public ActivationType activateHow { get; set; }
}
