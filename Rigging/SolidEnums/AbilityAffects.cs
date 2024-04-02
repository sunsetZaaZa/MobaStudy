using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class AbilityAffects : StaticEnumeration
{
    private AbilityAffects(int index, string name) : base(index, name) { }

    public static readonly AbilityAffects ENEMIES = new AbilityAffects(1, "Enemies");
    public static readonly AbilityAffects SELF = new AbilityAffects(2, "Self");
    public static readonly AbilityAffects ALLIES = new AbilityAffects(3, "Allies");
    public static readonly AbilityAffects TURRETS = new AbilityAffects(4, "Turrets");
    public static readonly AbilityAffects WARDS = new AbilityAffects(5, "Wards");
    public static readonly AbilityAffects TIBBERS = new AbilityAffects(6, "Tibbers");
    public static readonly AbilityAffects STRUCTURE = new AbilityAffects(7, "Structure");
    public static readonly AbilityAffects ENEMY = new AbilityAffects(8, "Enemy");
    public static readonly AbilityAffects TERRAIN = new AbilityAffects(9, "Terrain");
    public static readonly AbilityAffects STRUCTURES = new AbilityAffects(10, "Structures");
    public static readonly AbilityAffects SPIDERLINGS = new AbilityAffects(11, "Spiderlings");
    public static readonly AbilityAffects ALLIED_TURRETS = new AbilityAffects(12, "Allied Turrets");
    public static readonly AbilityAffects OATHSWORM_ALLY = new AbilityAffects(13, "Oathsworn Ally");

    public static readonly List<AbilityAffects> byIndex =
        new List<AbilityAffects>() { ENEMIES, SELF, ALLIES, TURRETS, WARDS, TIBBERS, 
                                        STRUCTURE, ENEMY, TERRAIN, STRUCTURES, SPIDERLINGS,
                                        ALLIED_TURRETS, OATHSWORM_ALLY };


    public static readonly int Count = byIndex.Count();
}

public enum AbilityAffectIndexer
{
    ENEMIES = 0,
    SELF = 1,
    ALLIES = 2,
    TURRETS = 3,
    WARDS = 4,
    TIBBERS = 5,
    STRUCTURE = 6,
    ENEMY = 7,
    TERRAIN = 8,
    STRUCTURES = 9,
    SPIDERLINGS = 10,
    ALLIED_TURRETS = 11,
    OATHSWORM_ALLY = 12
}
