using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class SpellShieldable : StaticEnumeration
{
    private SpellShieldable(int index, string name) : base(index, name) { }

    public static readonly SpellShieldable FALSE = new SpellShieldable(0, "False");
    public static readonly SpellShieldable TRUE = new SpellShieldable(1, "True");
    public static readonly SpellShieldable SPECIAL = new SpellShieldable(2, "Special");

    public static readonly List<SpellShieldable> byIndex = 
        new List<SpellShieldable>() { FALSE, TRUE, SPECIAL };

    public static readonly int Count = byIndex.Count();
}

public enum SpellShieldableIndexer
{
    FALSE = 0,
    TRUE = 1,
    SPECIAL = 2
}
