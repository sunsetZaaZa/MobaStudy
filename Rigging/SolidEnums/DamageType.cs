using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class DamageType : StaticEnumeration
{
    private DamageType(int index, string name) : base(index, name) { }

    public static readonly DamageType PHYSICAL = new DamageType(1, "Physical Damage");
    public static readonly DamageType MAGIC = new DamageType(2, "Magic Damage");
    public static readonly DamageType TRUE = new DamageType(3, "True Damage");
    public static readonly DamageType PURE = new DamageType(4, "Pure Damage");
    public static readonly DamageType MIXED = new DamageType(5, "Mixed Damage");
    public static readonly DamageType OTHER = new DamageType(6, "Other Damage");

    public static readonly List<DamageType> byIndex =
        new List<DamageType>() { PHYSICAL, MAGIC, TRUE, PURE, MIXED, OTHER };

    public static readonly int Count = byIndex.Count();
}

public enum DamageTypeIndexer
{
    PHYSICAL = 0,
    MAGIC = 1,
    TRUE = 2,
    PURE = 3,
    MIXED = 4,
    OTHER = 5
}
