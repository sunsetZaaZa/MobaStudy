using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityTargeting : StaticEnumeration
{
    private AbilityTargeting(int index, string name) : base(index, name) { }

    public static readonly AbilityTargeting DIRECTION = new AbilityTargeting(1, "Direction");
    public static readonly AbilityTargeting LOCATION = new AbilityTargeting(2, "Location");

    public static readonly List<AbilityTargeting> byIndex = 
        new List<AbilityTargeting>() { DIRECTION, LOCATION };

    public static readonly int Count = byIndex.Count;
}

public enum AbilityTargetingIndexer
{
    DIRECTION = 1,
    LOCATION = 2,
}
