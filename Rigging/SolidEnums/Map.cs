using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;

public class Map : StaticEnumeration
{
    private Map(int index, string name) : base(index, name) { }

    public static readonly Map SUMMONERS_RIFT = new Map(11, "Summoner's Rift");
    public static readonly Map HOWLING_ABYSS = new Map(12, "Howling Abyss");
    public static readonly Map NEXUS_BLITZ = new Map(21, "Nexus Blitz");

    public static readonly List<Map> byIndex = 
        new List<Map>() { SUMMONERS_RIFT, HOWLING_ABYSS, NEXUS_BLITZ };

    public static readonly int Count = byIndex.Count();
}

public enum MapIndexer
{
    SUMMONERS_RIFT = 0,
    HOWLING_ABYSS = 1,
    NEXUS_BLITZ = 2
}
