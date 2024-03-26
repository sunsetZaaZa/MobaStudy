using MobaGains.Rigging.Enum;
using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata;

public class Item
{
    public Item(int id, string name, bool active, bool inStore, List<int> from, List<int> to, List<ItemRank> ranks, List<ItemAttribute> attributes,
                string requiredChampion, string requiredAlly, string requiredBuffCurrencyName, int requiredBuffCurrencyCost,
                int specialRecipeId, bool isEnchantment, int price, int priceTotal, string iconPath, List<ItemStat> stats)
    {
        this.id = id;
        this.name = name;
        this.active = active;
        this.inStore = inStore;
        this.from = from;
        this.to = to;
        this.ranks = ranks;
        this.attributes = attributes;
        this.requiredChampion = requiredChampion;
        this.requiredAlly = requiredAlly;
        this.requiredBuffCurrencyName = requiredBuffCurrencyName;
        this.requiredBuffCurrencyCost = requiredBuffCurrencyCost;
        this.specialRecipeId = specialRecipeId;
        this.isEnchantment = isEnchantment;
        this.price = price;
        this.priceTotal = priceTotal;
        this.iconPath = iconPath;
        this.stats = stats;
    }

    public int id { get; set; }
    public string name { get; set; }
    public bool active { get; set; }
    public bool inStore { get; set; }
    public List<int> buildFrom { get; set; }
    public List<int> buildTo { get; set; }
    public List<ItemRank> ranks { get; set; }
    public List<ItemRole> roles { get; set; }
    public string requiredChampion { get; set; }
    public string requiredAlly { get; set; }
    public string requiredBuffCurrencyName { get; set; }
    public int requiredBuffCurrencyCost { get; set; }
    public int specialRecipeId { get; set; }
    public bool isEnchantment { get; set; }
    public int price { get; set; }
    public int priceTotal { get; set; }
    public int sell { get; set; }
    public string iconPath { get; set; }
    public List<ItemStat> stats { get; set; }
}
