using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityEffects : StaticEnumeration
{
    private AbilityEffects(int index, string name) : base(index, name) { }

    public static readonly AbilityEffects SPELL_AOE = new AbilityEffects(1, "Spell Area of Effect");
    public static readonly AbilityEffects AOE = new AbilityEffects(2, "Area of Effect");
    public static readonly AbilityEffects SPECIAL = new AbilityEffects(3, "Special");
    public static readonly AbilityEffects PROC = new AbilityEffects(4, "Proc");

    public static readonly List<AbilityEffects> byIndex =
        new List<AbilityEffects>() { SPELL_AOE, AOE, SPECIAL, PROC};

    public static readonly int Count = byIndex.Count();
}

public enum AbilityEffectsIndexer
{
    SPELL_AOE = 0,
    AREA_OF_EFFECT = 1,
    SPECIAL = 2,
    PROC = 3
}
