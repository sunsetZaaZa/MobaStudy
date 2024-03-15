

using MobaGains.Rigging.Enum;

namespace MobaGains.Rigging.Utilities.Metadata;

public class ItemStats
{
    public ItemStats(string id, string name, string description, bool active, bool inStore, List<string> buildFrom, List<string> buildToward, List<string> categories, int maxStacks, string requiredChampion, string requiredAlly, string requiredBuffCurrencyName, int requiredBuffCurrencyCost, int specialRecipeId, bool inEnchantment, int price, int totalPrice, string iconFilename, ItemType type)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.active = active;
        this.inStore = inStore;
        this.buildFrom = buildFrom;
        this.buildToward = buildToward;
        this.categories = categories;
        this.maxStacks = maxStacks;
        this.requiredChampion = requiredChampion;
        this.requiredAlly = requiredAlly;
        this.requiredBuffCurrencyName = requiredBuffCurrencyName;
        this.requiredBuffCurrencyCost = requiredBuffCurrencyCost;
        this.specialRecipeId = specialRecipeId;
        this.inEnchantment = inEnchantment;
        this.price = price;
        this.totalPrice = totalPrice;
        this.iconFilename = iconFilename;
        this.type = type;
    }

    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public bool active { get; set; }
    public bool inStore { get; set; }
    public List<string> buildFrom { get; set; }
    public List<string> buildToward { get; set; }
    public List<string> categories { get; set; }
    public int maxStacks { get; set; }
    public string requiredChampion { get; set; }
    public string requiredAlly { get; set; }
    public string requiredBuffCurrencyName { get; set; }
    public int requiredBuffCurrencyCost { get; set; }
    public int specialRecipeId { get; set; }
    public bool inEnchantment { get; set; }
    public int price { get; set; }
    public int totalPrice { get; set; }
    public string iconFilename { get; set; }
    public ItemType type { get; set; }
}
