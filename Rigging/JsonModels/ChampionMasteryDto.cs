namespace MobaGains.Rigging.JsonModels;

public class ChampionMasteryDto
{
    public ChampionMasteryDto(string puuid, long championPointsUntilNextLevel, bool chestGranted, long championId, long lastPlayTime, int championLevel, string summonerId, int championPoints, long championPointsSinceLastLevel, int tokensEarned)
    {
        this.puuid = puuid;
        this.championPointsUntilNextLevel = championPointsUntilNextLevel;
        this.chestGranted = chestGranted;
        this.championId = championId;
        this.lastPlayTime = lastPlayTime;
        this.championLevel = championLevel;
        this.summonerId = summonerId;
        this.championPoints = championPoints;
        this.championPointsSinceLastLevel = championPointsSinceLastLevel;
        this.tokensEarned = tokensEarned;
    }

    public string puuid { get; set; }
    public Int64 championPointsUntilNextLevel { get; set; }
    public bool chestGranted { get; set; }
    public Int64 championId { get; set; }
    public Int64 lastPlayTime { get; set; }
    public Int32 championLevel { get; set; }
    public string summonerId { get; set; }
    public Int32 championPoints { get; set; }
    public Int64 championPointsSinceLastLevel { get; set; }
    public Int32 tokensEarned { get; set; }
}
