using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class CharacterResource : StaticEnumeration
{
    private CharacterResource(int index, string name) : base(index, name) { }

    public static readonly CharacterResource NONE = new CharacterResource(1, "None");
    public static readonly CharacterResource NOCOST = new CharacterResource(2, "No Cost");
    public static readonly CharacterResource MANA = new CharacterResource(3, "Mana");
    public static readonly CharacterResource HEALTH = new CharacterResource(4, "Health");
    public static readonly CharacterResource ENERGY = new CharacterResource(5, "Energy");
    public static readonly CharacterResource ADRENALINE = new CharacterResource(6, "Adrenaline");
    public static readonly CharacterResource BLOODTHIRST = new CharacterResource(7, "Blood Thirst");
    public static readonly CharacterResource RAGE = new CharacterResource(8, "Rage");
    public static readonly CharacterResource FURY = new CharacterResource(9, "Fury");
    public static readonly CharacterResource FEROCITY = new CharacterResource(10, "Ferocity");
    public static readonly CharacterResource MAXIMUMHEALTH = new CharacterResource(11, "Maximum Health");
    public static readonly CharacterResource CURRENTHEALTH = new CharacterResource(12, "Current Health");
    public static readonly CharacterResource CHARGE = new CharacterResource(13, "Charge");
    public static readonly CharacterResource COURAGE = new CharacterResource(14, "Courage");
    public static readonly CharacterResource HEAT = new CharacterResource(15, "Heat");
    public static readonly CharacterResource GRIT = new CharacterResource(16, "Grit");
    public static readonly CharacterResource FLOW = new CharacterResource(17, "Flow");
    public static readonly CharacterResource SHIELD = new CharacterResource(18, "Shield");
    public static readonly CharacterResource SOULUNBOUND = new CharacterResource(19, "Soul Unbound");
    public static readonly CharacterResource BLOODWELL = new CharacterResource(20, "Blood Well");
    public static readonly CharacterResource OTHER = new CharacterResource(21, "Other");

    public static readonly List<CharacterResource> byIndex =
        new List<CharacterResource>() { NONE,  NOCOST, MANA, HEALTH, ENERGY, ADRENALINE, BLOODTHIRST, RAGE,
                                        FURY, FEROCITY, MAXIMUMHEALTH, CURRENTHEALTH, CHARGE, HEAT, GRIT, FLOW,
                                        SHIELD, SOULUNBOUND, BLOODWELL, OTHER };

    public static readonly int Count = byIndex.Count();
}

public enum CharacterResourceIndexer
{
    NONE = 0,
    NOCOST = 1,
    MANA = 2,
    HEALTH = 3,
    ENERGY = 4,
    ADRENALINE = 5,
    BLOODTHIRST = 6,
    RAGE = 7,
    FURY = 8,
    FEROCITY = 9,
    MAXIMUMHEALTH = 10,
    CURRENTHEALTH = 11,
    CHARGE = 12,
    COURAGE = 13,
    HEAT = 14,
    GRIT = 15,
    FLOW = 16,
    SHIELD = 17,
    SOULUNBOUND = 18,
    BLOODWELL = 19,
    OTHER = 20
}
