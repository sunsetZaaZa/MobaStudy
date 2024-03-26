using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class ChampionRole : StaticEnumeration
{
    private ChampionRole(int index, string name) : base(index, name) { }

    public static readonly ChampionRole TANK = new ChampionRole(1, "Tank");
    public static readonly ChampionRole FIGHTER = new ChampionRole(2, "Fighter");
    public static readonly ChampionRole MAGE = new ChampionRole(3, "Mage");
    public static readonly ChampionRole MARKSMAN = new ChampionRole(4, "Marksman");
    public static readonly ChampionRole SUPPORT = new ChampionRole(5, "Support");
    public static readonly ChampionRole WARDEN = new ChampionRole(6, "Warden");
    public static readonly ChampionRole VANGUARD = new ChampionRole(7, "Vanguard");
    public static readonly ChampionRole JUGGERNAUT = new ChampionRole(8, "Juggernaut");
    public static readonly ChampionRole CONTROLLER = new ChampionRole(9, "Controller");
    public static readonly ChampionRole SKIRMISHER = new ChampionRole(10, "Skirmisher");
    public static readonly ChampionRole DIVER = new ChampionRole(11, "Diver");
    public static readonly ChampionRole SLAYER = new ChampionRole(12, "Slayer");
    public static readonly ChampionRole BURST = new ChampionRole(13, "Burst");
    public static readonly ChampionRole BATTLEMAGE = new ChampionRole(14, "Battlemage");
    public static readonly ChampionRole ENCHANTER = new ChampionRole(15, "Enchanter");
    public static readonly ChampionRole CATCHER = new ChampionRole(16, "Catcher");
    public static readonly ChampionRole ASSASSIN = new ChampionRole(17, "Assassin");
    public static readonly ChampionRole SPECIALIST = new ChampionRole(18, "Specialist");
    public static readonly ChampionRole ARTILLERY = new ChampionRole(19, "Artillery");

    public static readonly List<ChampionRole> byIndex =
        new List<ChampionRole>() { TANK, FIGHTER, MAGE, MARKSMAN, SUPPORT, WARDEN, VANGUARD, JUGGERNAUT, CONTROLLER,
                                    SKIRMISHER, DIVER, SLAYER, BURST, BATTLEMAGE, ENCHANTER, CATCHER, ASSASSIN, SPECIALIST, ARTILLERY };

    public static readonly int Count = byIndex.Count;
}

public enum ChampionRoleIndexer
{
    TANK = 1,
    FIGHTER = 2,
    MAGE = 3,
    MARKSMAN = 4,
    SUPPORT = 5,
    WARDEN = 6,
    VANGUARD = 7,
    JUGGERNAUT = 8,
    CONTROLLER = 9,
    SKIRMISHER = 10,
    DIVER = 11,
    SLAYER = 12,
    BURST = 13,
    BATTLEMAGE = 14,
    ENCHANTER = 15,
    CATCHER = 16,
    ASSASSIN = 17,
    SPECIALIST = 18,
    ARTILLERY = 19,
}
