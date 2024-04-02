using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityUnit : StaticEnumeration
{
    private AbilityUnit(int index, string name) : base(index, name) { }

    public static readonly AbilityUnit NONE = new AbilityUnit(1, "");
    public static readonly AbilityUnit FLAT = new AbilityUnit(2, "Flat");
    public static readonly AbilityUnit PERCENT_AP = new AbilityUnit(2, "% AP");
    public static readonly AbilityUnit PERCENT_BONUS_AD = new AbilityUnit(3, "% bonus AD");

    public static readonly List<AbilityUnit> byIndex = 
        new List<AbilityUnit>() { NONE, FLAT, PERCENT_AP, PERCENT_BONUS_AD };

    public static readonly int Count = byIndex.Count();
}

public enum AbilityUnitIndexer
{
    NONE = 0,
    FLAT = 1,
    PERCENT_AP = 2,
    PERCENT_BONUS_AD = 3
}