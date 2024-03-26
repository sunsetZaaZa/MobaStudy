using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityAffects : StaticEnumeration
{
    private AbilityAffects(int index, string name) : base(index, name) { }

    public static readonly AbilityAffects ENEMIES = new AbilityAffects(1, "Enemies");
    public static readonly AbilityAffects SELF = new AbilityAffects(2, "Self");

    public static readonly List<AbilityAffects> byIndex =
        new List<AbilityAffects>() { ENEMIES, SELF };

    public static readonly int Count = byIndex.Count;
}

public enum AbilityAffectIndexer
{
    ENEMIES = 1,
    SELF = 2
}
