using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class ChampStatType : StaticEnumeration
{
    private ChampStatType(int index, string name)  : base(index, name) { }

    public static readonly ChampStatType HEALTH = new ChampStatType(1, "Health");
    public static readonly ChampStatType HEALTH_REGEN = new ChampStatType(2, "Health Regeneration");
    public static readonly ChampStatType MANA = new ChampStatType(3, "Mana");
    public static readonly ChampStatType MANA_REGEN = new ChampStatType(4, "Mana Regeneration");
    public static readonly ChampStatType ARMOR = new ChampStatType(5, "Armor");
    public static readonly ChampStatType MAGIC_RESISTANCE = new ChampStatType(6, "Magic Resistance");
    public static readonly ChampStatType ATTACK_DAMAGE = new ChampStatType(7, "Attack Damage");
    public static readonly ChampStatType MOVESPEED = new ChampStatType(8, "Move Speed");
    public static readonly ChampStatType ACQUISITION_RADIUS = new ChampStatType(9, "Acquisition Radius");
    public static readonly ChampStatType SELECTION_RADIUS = new ChampStatType(10, "Selection Radius");
    public static readonly ChampStatType PATHING_RADIUS = new ChampStatType(11, "Pathing Radius");
    public static readonly ChampStatType GAMEPLAY_RADIUS = new ChampStatType(12, "Gameplay Radius");
    public static readonly ChampStatType CRITICAL_STRIKE_DAMAGE = new ChampStatType(13, "Critical Strike Damage");
    public static readonly ChampStatType CRITICAL_STRIKE_DAMAGE_MODIFIER = new ChampStatType(14, "Critical Strike Damage Modifier");
    public static readonly ChampStatType ATTACK_SPEED = new ChampStatType(15, "Attack Speed");
    public static readonly ChampStatType ATTACK_SPEED_RATIO = new ChampStatType(16, "Attack Speed Ratio");
    public static readonly ChampStatType ATTACK_CAST_TIME = new ChampStatType(17, "Attack Cast Time");
    public static readonly ChampStatType ATTACK_TOTAL_TIME = new ChampStatType(18, "Attack Total Time");
    public static readonly ChampStatType ATTACK_DELAY_OFFSET = new ChampStatType(19, "Attack Delay Offset");
    public static readonly ChampStatType ATTACK_RANGE = new ChampStatType(20, "Attack Range");
    public static readonly ChampStatType ARAM_DAMAGE_TAKEN = new ChampStatType(21, "ARAM Damage Taken");
    public static readonly ChampStatType ARAM_DAMAGE_DEALT = new ChampStatType(22, "ARAM Damage Dealt");
    public static readonly ChampStatType ARAM_HEALING = new ChampStatType(23, "ARAM Healing");
    public static readonly ChampStatType ARAM_SHIELDING = new ChampStatType(24, "ARAM Shielding");
    public static readonly ChampStatType URF_DAMAGE_TAKEN = new ChampStatType(25, "URF Damage Taken");
    public static readonly ChampStatType URF_DAMAGE_DEALT = new ChampStatType(26, "URF Damage Dealt");
    public static readonly ChampStatType URF_HEALING = new ChampStatType(27, "URF Healing");
    public static readonly ChampStatType URF_SHIELDING = new ChampStatType(28, "URF Shielding");

    public static readonly List<ChampStatType> byIndex =
        new List<ChampStatType>() { HEALTH, HEALTH_REGEN, MANA, MANA_REGEN, ARMOR, MAGIC_RESISTANCE, ATTACK_DAMAGE,
                                    MOVESPEED, ACQUISITION_RADIUS, SELECTION_RADIUS, PATHING_RADIUS, GAMEPLAY_RADIUS,
                                    CRITICAL_STRIKE_DAMAGE, CRITICAL_STRIKE_DAMAGE_MODIFIER, ATTACK_SPEED, ATTACK_SPEED_RATIO,
                                    ATTACK_CAST_TIME, ATTACK_TOTAL_TIME, ATTACK_DELAY_OFFSET, ATTACK_RANGE, ARAM_DAMAGE_TAKEN,
                                    ARAM_DAMAGE_DEALT, ARAM_HEALING, ARAM_SHIELDING, URF_DAMAGE_TAKEN, URF_DAMAGE_DEALT,
                                    URF_HEALING, URF_SHIELDING };

    public static readonly int Count = byIndex.Count();
}

public enum ChampStatTypeIndexer
{
    HEALTH = 0,
    HEALTH_REGEN = 1,
    MANA = 2,
    MANA_REGEN = 3,
    ARMOR = 4,
    MAGIC_RESISTANCE = 5,
    ATTACK_DAMAGE = 6,
    MOVESPEED = 7,
    ACQUISITION_RADIUS = 8,
    SELECTION_RADIUS = 9,
    PATHING_RADIUS = 10,
    GAMEPLAY_RADIUS = 11,
    CRITICAL_STRIKE_DAMAGE = 12,
    CRITICAL_STRIKE_DAMAGE_MODIFIER = 13,
    ATTACK_SPEED = 14,
    ATTACK_SPEED_RATIO = 15,
    ATTACK_CAST_TIME = 16,
    ATTACK_TOTAL_TIME = 17,
    ATTACK_DELAY_OFFSET = 18,
    ATTACK_RANGE = 19,
    ARAM_DAMAGE_TAKEN = 20,
    ARAM_DAMAGE_DEALT = 21,
    ARAM_HEALING = 22,
    ARAM_SHIELDING = 23,
    URF_DAMAGE_TAKEN = 24,
    URF_DAMAGE_DEALT = 25,
    URF_HEALING = 26,
    URF_SHIELDING = 27
}
