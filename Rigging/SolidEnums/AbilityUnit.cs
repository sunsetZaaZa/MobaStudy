using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityUnit : StaticEnumeration
{
    private AbilityUnit(int index, string name) : base(index, name) { }

    public static readonly AbilityUnit FLAT = new AbilityUnit(0, "");
    public static readonly AbilityUnit PERCENT_AP = new AbilityUnit(1, "% AP");
    public static readonly AbilityUnit PERCENT_BONUS_AD = new AbilityUnit(2, "% bonus AD");

    public static readonly List<AbilityUnit> byIndex = 
        new List<AbilityUnit>() { FLAT, PERCENT_AP, PERCENT_BONUS_AD };

    public static readonly int Count = byIndex.Count;
}

public enum AbilityUnitIndexer
{
    FLAT = 0,
    PERCENT_AP = 1,
    PERCENT_BONUS_AD = 2
}