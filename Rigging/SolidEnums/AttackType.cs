using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AttackType : StaticEnumeration
{
    private AttackType(int index, string name) : base(index, name) { }

    public static readonly AttackType MELEE = new AttackType(1, "Melee");
    public static readonly AttackType RANGE = new AttackType(2, "Range");

    public static readonly List<AttackType> byIndex = 
        new List<AttackType>() { MELEE, RANGE };

    public static readonly int Count = byIndex.Count();
}

public enum AttackTypeIndexer
{
    MELEE = 0,
    RANGE = 1
}
