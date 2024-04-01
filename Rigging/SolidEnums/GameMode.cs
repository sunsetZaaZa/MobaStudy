using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class GameMode : StaticEnumeration
{
    private GameMode(int index, string name) : base(index, name) { }

    public static readonly GameMode TUTORIAL = new GameMode(1, "Tutorial");
    public static readonly GameMode AI = new GameMode(2, "AI");
    public static readonly GameMode CLASSIC = new GameMode(3, "Classic");
    public static readonly GameMode ARAM = new GameMode(4, "All Random All Middle");
    public static readonly GameMode URF = new GameMode(5, "Ultimate Rapid Fire");

    public static readonly List<GameMode> byIndex =
        new List<GameMode>() { TUTORIAL, AI, CLASSIC, ARAM, URF };

    public static readonly int Count = byIndex.Count();
}

public enum GameModeIndexer
{
    TUTORIAL = 0,
    AI = 1,
    CLASSIC = 2,
    ARAM = 3,
    URF = 4,
}
