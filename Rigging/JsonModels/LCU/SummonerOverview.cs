namespace MobaGains.Rigging.JsonModels.LCU;

public class RerollPoints
{
    public RerollPoints(int currentPoints, int maxRolls, int numberOfRolls, int pointsCostToRoll, int pointsToReroll)
    {
        this.currentPoints = currentPoints;
        this.maxRolls = maxRolls;
        this.numberOfRolls = numberOfRolls;
        this.pointsCostToRoll = pointsCostToRoll;
        this.pointsToReroll = pointsToReroll;
    }

    public int currentPoints { get; set; }
    public int maxRolls { get; set; }
    public int numberOfRolls { get; set; }
    public int pointsCostToRoll { get; set; }
    public int pointsToReroll { get; set; }
}

public class SummonerOverview
{
    public SummonerOverview(string accountId, string displayName, string gameName, string internalName, bool nameChangeFlag, int percentCompleteForNextLevel, string privacy, int profileIconId, string puuid, RerollPoints rerollPoints, string summonerId, string summonerLevel, string tagLine, bool unnamed, int xpSinceLastLevel, int xpUntilNextLevel)
    {
        this.accountId = accountId;
        this.displayName = displayName;
        this.gameName = gameName;
        this.internalName = internalName;
        this.nameChangeFlag = nameChangeFlag;
        this.percentCompleteForNextLevel = percentCompleteForNextLevel;
        this.privacy = privacy;
        this.profileIconId = profileIconId;
        this.puuid = puuid;
        this.rerollPoints = rerollPoints;
        this.summonerId = summonerId;
        this.summonerLevel = summonerLevel;
        this.tagLine = tagLine;
        this.unnamed = unnamed;
        this.xpSinceLastLevel = xpSinceLastLevel;
        this.xpUntilNextLevel = xpUntilNextLevel;
    }

    public string accountId { get; set; }
    public string displayName { get; set; }
    public string gameName { get; set; }
    public string internalName { get; set; }
    public bool nameChangeFlag { get; set; }
    public int percentCompleteForNextLevel { get; set; }
    public string privacy { get; set; }
    public int profileIconId { get; set; }
    public string puuid { get; set; }
    public RerollPoints rerollPoints { get; set; }
    public string summonerId { get; set; }
    public string summonerLevel { get; set; }
    public string tagLine { get; set; }
    public bool unnamed { get; set; }
    public int xpSinceLastLevel { get; set; }
    public int xpUntilNextLevel { get; set; }
}
