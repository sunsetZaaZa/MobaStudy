using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityAttribute : StaticEnumeration
{
    private AbilityAttribute(int index, string name) : base(index, name) { }

    public static readonly AbilityAttribute INCREASED_MINION_DAMAGE = new AbilityAttribute(1, "Increased Minion Damage");
    public static readonly AbilityAttribute MAGIC_DAMAGE = new AbilityAttribute(2, "Magic Damage");
    public static readonly AbilityAttribute ADDITIONAL_MAGIC_DAMAGE = new AbilityAttribute(3, "Additional Magic Damage");

    public static readonly List<AbilityAttribute> byIndex =
        new List<AbilityAttribute>() { INCREASED_MINION_DAMAGE, MAGIC_DAMAGE, ADDITIONAL_MAGIC_DAMAGE };

    public static readonly int Count = byIndex.Count();
}

public enum AbilityAttributeIndexer
{
    INCREASED_MINION_DAMAGE = 0,
    MAGIC_DAMAGE = 1,
    ADDITIONAL_MAGIC_DAMAGE = 2
}
