namespace MobaGains.Rigging.JsonModels.RiotWebApi;

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
    public long championPointsUntilNextLevel { get; set; }
    public bool chestGranted { get; set; }
    public long championId { get; set; }
    public long lastPlayTime { get; set; }
    public int championLevel { get; set; }
    public string summonerId { get; set; }
    public int championPoints { get; set; }
    public long championPointsSinceLastLevel { get; set; }
    public int tokensEarned { get; set; }
}
