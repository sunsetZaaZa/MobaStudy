using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class ItemStatType : StaticEnumeration
{
    private ItemStatType(int index, string name) : base(index, name) { }

    public static readonly ItemStatType ABILITY_POWER = new ItemStatType(1, "Ability Power");
    public static readonly ItemStatType ARMOR = new ItemStatType(2, "Armor");
    public static readonly ItemStatType ARMOR_PENETRATION = new ItemStatType(3, "Armor Penetration");
    public static readonly ItemStatType ATTACK_DAMAGE = new ItemStatType(4, "Attack Damage");
    public static readonly ItemStatType ATTACK_SPEED = new ItemStatType(5, "Attack Speed");
    public static readonly ItemStatType COOLDOWN_REDUCTION = new ItemStatType(6, "Cooldown Reduction");
    public static readonly ItemStatType CRITICAL_STRIKE_CHANCE = new ItemStatType(7, "Critical Strike Chance");
    public static readonly ItemStatType GOLD_PER = new ItemStatType(8, "Gold Per 10 Seconds");
    public static readonly ItemStatType HEAL_AND_SHIELD_POWER = new ItemStatType(9, "Heal and Shield Power");
    public static readonly ItemStatType HEALTH = new ItemStatType(10, "Health");
    public static readonly ItemStatType HEALTH_REGEN = new ItemStatType(11, "Health Regeneration");
    public static readonly ItemStatType LETHALITY = new ItemStatType(12, "Lethality");
    public static readonly ItemStatType LIFE_STEAL = new ItemStatType(13, "Life Steal");
    public static readonly ItemStatType MAGIC_PENETRACTION = new ItemStatType(14, "Magic Penetration");
    public static readonly ItemStatType MAGIC_RESISTANCE = new ItemStatType(15, "Magic Resistance");
    public static readonly ItemStatType MANA = new ItemStatType(16, "Mana");
    public static readonly ItemStatType MANA_REGEN = new ItemStatType(17, "Mana Regeneration");
    public static readonly ItemStatType MOVESPEED = new ItemStatType(18, "Move Speed");
    public static readonly ItemStatType ABILITY_HASTE = new ItemStatType(19, "Ability Haste");
    public static readonly ItemStatType OMNIVAMP = new ItemStatType(20, "Omni Vamp");
    public static readonly ItemStatType TENACITY = new ItemStatType(21, "Tenacity");

    public static readonly List<ItemStatType> byIndex =
        new List<ItemStatType>() { ABILITY_POWER, ARMOR, ARMOR_PENETRATION, ATTACK_DAMAGE, ATTACK_SPEED, COOLDOWN_REDUCTION,
                                    CRITICAL_STRIKE_CHANCE, GOLD_PER, HEAL_AND_SHIELD_POWER, HEALTH, HEALTH_REGEN, LETHALITY,
                                    LIFE_STEAL, MAGIC_PENETRACTION, MAGIC_RESISTANCE, MANA, MANA_REGEN, MOVESPEED, ABILITY_HASTE,
                                    OMNIVAMP, TENACITY };

    public static readonly int Count = byIndex.Count();
}

public enum ItemStatTypeIndexer
{
    ABILITY_POWER = 0,
    ARMOR = 1,
    ARMOR_PENETRATION = 2,
    ATTACK_DAMAGE = 3,
    ATTACK_SPEED = 4,
    COOLDOWN_REDUCTION = 5,
    CRITIAL_STRIKE_CHANGE = 6,
    GOLD_PER = 7,
    HEAL_AND_SHIELD_POWER = 8,
    HEALTH = 9,
    HEALTH_REGEN = 10,
    LETHALITY = 11,
    LIFE_STEAL = 12,
    MAGIC_PENETRATION = 13,
    MAGIC_RESISTANCE = 14,
    MANA = 15,
    MANA_REGEN = 16,
    MOVESPEED = 17,
    ABILITY_HASTE = 18,
    OMNIVAMP = 19,
    TENACITY = 20
}
