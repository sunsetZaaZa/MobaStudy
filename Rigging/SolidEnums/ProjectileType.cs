using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class ProjectileType : StaticEnumeration
{
    private ProjectileType(int index, string name) : base(index, name) { }

    public static readonly ProjectileType FALSE = new ProjectileType(1, "False");
    public static readonly ProjectileType TRUE = new ProjectileType(2, "True");
    public static readonly ProjectileType SPECIAL = new ProjectileType(3, "Special");
    public static readonly ProjectileType UNBLOCKABLE = new ProjectileType(4, "Unblockable");

    public static readonly List<ProjectileType> byIndex = 
        new List<ProjectileType>() { FALSE, TRUE, SPECIAL, UNBLOCKABLE };

    public static readonly int Count = byIndex.Count();
}

public enum ProjectileTypeIndexer
{
    FALSE = 0,
    TRUE = 1,
    SPECIAL = 2,
    UNBLOCKABLE = 3
}
