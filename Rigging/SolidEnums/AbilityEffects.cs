using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityEffects : StaticEnumeration
{
    private AbilityEffects(int index, string name) : base(index, name) { }

    public static readonly AbilityEffects SPELL_AOE = new AbilityEffects(1, "Spell Area of Effect");
    public static readonly AbilityEffects AOE = new AbilityEffects(2, "Area of Effect");
    public static readonly AbilityEffects SPECIAL = new AbilityEffects(3, "Special");
    public static readonly AbilityEffects PROC = new AbilityEffects(4, "Proc");
    public static readonly AbilityEffects AOE_DOT = new AbilityEffects(5, "Area of Effect - Damage over Time");
    public static readonly AbilityEffects SINGLE_TARGET = new AbilityEffects(6, "Single Target");
    public static readonly AbilityEffects SPELL = new AbilityEffects(7, "Spell");
    public static readonly AbilityEffects SHIELD = new AbilityEffects(8, "Shield");
    public static readonly AbilityEffects BASIC = new AbilityEffects(9, "Basic");
    public static readonly AbilityEffects DOT = new AbilityEffects(10, "Damage of Time");
    public static readonly AbilityEffects HEAL = new AbilityEffects(11, "Heal");
    public static readonly AbilityEffects DEFAULT = new AbilityEffects(12, "Default");
    public static readonly AbilityEffects PERIODIC = new AbilityEffects(13, "Periodic");
    public static readonly AbilityEffects PET = new AbilityEffects(14, "Pet");
    public static readonly AbilityEffects ATTACK = new AbilityEffects(15, "Attack");

    public static readonly List<AbilityEffects> byIndex =
        new List<AbilityEffects>() { SPELL_AOE, AOE, SPECIAL, PROC, AOE_DOT, SINGLE_TARGET, SPELL,
                                        SHIELD, BASIC, DOT, HEAL, DEFAULT, PERIODIC, PET, ATTACK };

    public static readonly int Count = byIndex.Count();
}

public enum AbilityEffectsIndexer
{
    SPELL_AOE = 0,
    AREA_OF_EFFECT = 1,
    SPECIAL = 2,
    PROC = 3,
    AOE_DOT = 4,
    SINGLE_TARGET = 5,
    SPELL = 6,
    SHIELD = 7,
    BASIC = 8,
    DOT = 9,
    HEAL = 10,
    DEFAULT = 11,
    PERIODIC = 12,
    PET = 13,
    ATTACK = 14
}
