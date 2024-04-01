using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class ItemRank : StaticEnumeration
{
    private ItemRank(int index, string name) : base(index, name) { }

    public static readonly ItemRank MYTHIC = new ItemRank(1, "Mythic");
    public static readonly ItemRank LEGENDARY = new ItemRank(2, "Legendary");
    public static readonly ItemRank EPIC = new ItemRank(3, "Epic");
    public static readonly ItemRank BASIC = new ItemRank(4, "Basic");
    public static readonly ItemRank STARTER = new ItemRank(5, "Starter");
    public static readonly ItemRank CONSUMABLE = new ItemRank(6, "Consumable");
    public static readonly ItemRank POTION = new ItemRank(7, "Potion");
    public static readonly ItemRank BOOTS = new ItemRank(8, "Boots");
    public static readonly ItemRank TRINKET = new ItemRank(9, "Trinket");
    public static readonly ItemRank DISTRIBUTED = new ItemRank(10, "Distributed");
    public static readonly ItemRank MINION = new ItemRank(11, "Minion");
    public static readonly ItemRank TURRET = new ItemRank(12, "Turret");
    public static readonly ItemRank SPECIAL = new ItemRank(13, "Special");

    public static readonly List<ItemRank> byIndex =
        new List<ItemRank>() { MYTHIC, LEGENDARY, EPIC, BASIC, STARTER, CONSUMABLE, POTION,
                                BOOTS, TRINKET, DISTRIBUTED, MINION, TURRET, SPECIAL };

    public static readonly int Count = byIndex.Count();
}

public enum ItemRankIndexer
{
    MYTHIC = 0,
    LEGENDARY = 1,
    EPIC = 2,
    BAISC = 3,
    STARTER = 4,
    CONSUMABLE = 5,
    POTION = 6,
    BOOTS = 7,
    TRINKET = 8,
    DISTRIBUTED = 9,
    MINION = 10,
    TURRET = 11,
    SPECIAL = 12,
}