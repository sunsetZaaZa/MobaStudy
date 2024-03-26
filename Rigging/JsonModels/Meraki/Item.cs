using MobaGains.Rigging.JsonModels.Meraki.ItemParts;

namespace MobaGains.Rigging.JsonModels.Meraki;

public class Item
{
    public string id { get; set; }
    public ItemBreakdown stats { get; set; }
}
