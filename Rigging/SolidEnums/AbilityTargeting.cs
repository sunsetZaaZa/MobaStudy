using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityTargeting : StaticEnumeration
{
    private AbilityTargeting(int index, string name) : base(index, name) { }

    public static readonly AbilityTargeting DIRECTION = new AbilityTargeting(1, "Direction");
    public static readonly AbilityTargeting LOCATION = new AbilityTargeting(2, "Location");
    public static readonly AbilityTargeting VECTOR = new AbilityTargeting(3, "Vector");
    public static readonly AbilityTargeting UNIT = new AbilityTargeting(4, "Unit");
    public static readonly AbilityTargeting AUTO = new AbilityTargeting(5, "Auto");
    public static readonly AbilityTargeting PASSIVE = new AbilityTargeting(6, "Passive");
    public static readonly AbilityTargeting NOT_APPLICABLE = new AbilityTargeting(7, "Not Applicable");
    public static readonly AbilityTargeting VARIED = new AbilityTargeting(8, "Varied");

    public static readonly List<AbilityTargeting> byIndex = 
        new List<AbilityTargeting>() { DIRECTION, LOCATION, VECTOR, UNIT, AUTO, PASSIVE, NOT_APPLICABLE, VARIED };

    public static readonly int Count = byIndex.Count();
}

public enum AbilityTargetingIndexer
{
    DIRECTION = 0,
    LOCATION = 1,
    VECTOR = 2,
    UNIT = 3,
    AUTO = 4,
    PASSIVE = 5,
    NOT_APPLICABLE = 6,
    VARIED = 7
}
