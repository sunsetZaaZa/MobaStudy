namespace MobaGains.Entities.LegendsDto;

public class ChampionMastery
{
    public ChampionMastery(Guid accountGuid, long championId, long championPointsUntilNextLevel, bool chestGranted, long lastPlayTime, int championLevel, string summonerId, int championPoints, long championPointsSinceLastLevel, int tokensEarned)
    {
        this.accountGuid = accountGuid;
        this.championId = championId;
        this.championPointsUntilNextLevel = championPointsUntilNextLevel;
        this.chestGranted = chestGranted;
        this.lastPlayTime = lastPlayTime;
        this.championLevel = championLevel;
        this.championPoints = championPoints;
        this.championPointsSinceLastLevel = championPointsSinceLastLevel;
        this.tokensEarned = tokensEarned;
    }

    public Guid accountGuid { get; set; }//Foreign Key of Account & Primary Key to ChampionMastery
    public long championId { get; set; } //Primary Key
    public long championPointsUntilNextLevel { get; set; }
    public bool chestGranted { get; set; }
    public long lastPlayTime { get; set; }
    public int championLevel { get; set; }
    public int championPoints { get; set; }
    public long championPointsSinceLastLevel { get; set; }
    public int tokensEarned { get; set; }
}
