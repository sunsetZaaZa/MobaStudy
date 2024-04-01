using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class ItemRole : StaticEnumeration
{
    private ItemRole(int index, string name) : base(index, name) { }

    public static readonly ItemRole TANK = new ItemRole(1, "Tank");
    public static readonly ItemRole SUPPORT = new ItemRole(2, "Support");
    public static readonly ItemRole JUNGLE = new ItemRole(3, "Jungle");
    public static readonly ItemRole LANE = new ItemRole(4, "Lane");

    public static readonly ItemRole HEALTH = new ItemRole(5, "Health");
    public static readonly ItemRole HEALTHREGEN = new ItemRole(6, "Health Regen");
    public static readonly ItemRole MANA = new ItemRole(7, "Mana");
    public static readonly ItemRole MANAREGEN = new ItemRole(8, "Mana Regen");
    public static readonly ItemRole DAMAGE = new ItemRole(9, "Damage");
    public static readonly ItemRole ARMOR = new ItemRole(10, "Armor");
    public static readonly ItemRole ONHIT = new ItemRole(11, "OnHit");
    public static readonly ItemRole SPELLDAMAGE = new ItemRole(12, "Spell Damage");
    public static readonly ItemRole SPELLBLOCK = new ItemRole(13, "Spell Block");
    public static readonly ItemRole SPELLVAMP = new ItemRole(14, "Spell Vamp");
    public static readonly ItemRole LIFESTEAL = new ItemRole(15, "LifeSteal");
    public static readonly ItemRole ATTACKDAMAGE = new ItemRole(16, "Attack Damage");
    public static readonly ItemRole CRITICALSTRIKE = new ItemRole(17, "Critical Strike");
    public static readonly ItemRole COOLDOWNREDUCTION = new ItemRole(18, "Cooldown Reduction");
    public static readonly ItemRole ABILITYHASTE = new ItemRole(19, "Ability Haste");
    public static readonly ItemRole MAGICPENETRATION = new ItemRole(20, "Magic Penetration");
    public static readonly ItemRole GOLDPER = new ItemRole(21, "Gold Per");
    public static readonly ItemRole TENACITY = new ItemRole(22, "Tenacity");
    public static readonly ItemRole SLOW = new ItemRole(23, "Slow");
    public static readonly ItemRole ARMORPENETRATION = new ItemRole(24, "Armor Penetration");
    public static readonly ItemRole MAGICRESIST = new ItemRole(25, "Magic Resist");
    public static readonly ItemRole AURA = new ItemRole(26, "Aura");
    public static readonly ItemRole ATTACKSPEED = new ItemRole(27, "Attack Speed");
    public static readonly ItemRole STEALTH = new ItemRole(28, "Stealth");
    public static readonly ItemRole BOOTS = new ItemRole(29, "Boots");
    public static readonly ItemRole CONSUMABLE = new ItemRole(30, "Consumable");
    public static readonly ItemRole TRINKETS = new ItemRole(31, "Trinkets");
    public static readonly ItemRole VISION = new ItemRole(32, "Vision");
    public static readonly ItemRole ACTIVE = new ItemRole(33, "Active");
    public static readonly ItemRole NONBOOTSMOVEMENT = new ItemRole(34, "Nonboots Movement");

    public static readonly List<ItemRole> byIndex =
        new List<ItemRole>() { TANK, SUPPORT, JUNGLE, LANE, HEALTH, HEALTHREGEN, MANA, MANAREGEN, DAMAGE,
                                ARMOR, ONHIT, SPELLDAMAGE, SPELLBLOCK, SPELLVAMP, LIFESTEAL, ATTACKDAMAGE,
                                CRITICALSTRIKE, COOLDOWNREDUCTION, ABILITYHASTE, MAGICPENETRATION, GOLDPER,
                                TENACITY, SLOW, ARMORPENETRATION, MAGICRESIST, AURA, ATTACKSPEED, STEALTH,
                                BOOTS, CONSUMABLE, TRINKETS, VISION, ACTIVE, NONBOOTSMOVEMENT };

    public static readonly int Count = byIndex.Count();
}

public enum ItemRoleIndexer
{
    TANK = 0,
    SUPPORT = 1,
    JUNGLE = 2,
    LANE = 3,
    HEALTH = 4,
    HEALTHREGEN = 5,
    MANA = 6,
    MANAREGEN = 7,
    DAMAGE = 8,
    ARMOR = 9,
    ONHIT = 10,
    SPELLDAMAGE = 11,
    SPELLBLOCK = 12,
    SPELLVAMP = 13,
    LIFESTEAL = 14,
    ATTACKDAMAGE = 15,
    CRITICALSTRIKE = 16,
    COOLDOWNREDUCTION = 17,
    ABILITYHASTE = 18,
    MAGICPENETRATION = 19,
    GOLDPER = 20,
    TENACITY = 21,
    SLOW = 22,
    ARMORPENETRATION = 23,
    MAGICRESIST = 24,
    AURA = 25,
    ATTACKSPEED = 26,
    STEALTH = 27,
    BOOTS = 28,
    CONSUMABLE = 29,
    TRINKETS = 30,
    VISION = 31,
    ACTIVE = 32,
    NONBOOTSMOVEMENT = 33
}
