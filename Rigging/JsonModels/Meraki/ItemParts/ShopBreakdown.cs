namespace MobaGains.Rigging.JsonModels.Meraki.ItemParts;

public struct Price
{
    public int total { get; set; }
    public int combined { get; set; }
    public int sell { get; set; }
}

public struct ShopBreakdown
{
    public Price prices { get; set; }
    public bool purchasable { get; set; }
    public List<string> tags { get; set; }
}
