using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class ItemRank : StaticEnumeration
{
    private ItemRank(int index, string name) : base(index, name) { }

    public static readonly ItemRank MYTHIC = new ItemRank(1, "Mythic");
    public static readonly ItemRank LEGENDARY = new ItemRank(2, "Legendary");
    public static readonly ItemRank EPIC = new ItemRank(3, "Epic");
    public static readonly ItemRank BASIC = new ItemRank(4, "Basic");
    public static readonly ItemRank STARTER = new ItemRank(6, "Starter");
    public static readonly ItemRank CONSUMABLE = new ItemRank(7, "Consumable");
    public static readonly ItemRank POTION = new ItemRank(8, "Potion");
    public static readonly ItemRank BOOTS = new ItemRank(9, "Boots");
    public static readonly ItemRank TRINKET = new ItemRank(10, "Trinket");
    public static readonly ItemRank DISTRIBUTED = new ItemRank(11, "Distributed");
    public static readonly ItemRank MINION = new ItemRank(12, "Minion");
    public static readonly ItemRank TURRET = new ItemRank(13, "Turret");
    public static readonly ItemRank SPECIAL = new ItemRank(14, "Special");
}
