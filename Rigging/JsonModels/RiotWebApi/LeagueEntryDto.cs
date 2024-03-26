namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class LeagueEntryDto
{
    public LeagueEntryDto(string leagueId, string summonerId, string summonerName, string queueType, string tier, string rank, int leaguePoints, int wins, int losses, bool hotStreak, bool veteran, bool freshBlood, bool inactive, MiniSeriesDTO miniSeries)
    {
        this.leagueId = leagueId;
        this.summonerId = summonerId;
        this.summonerName = summonerName;
        this.queueType = queueType;
        this.tier = tier;
        this.rank = rank;
        this.leaguePoints = leaguePoints;
        this.wins = wins;
        this.losses = losses;
        this.hotStreak = hotStreak;
        this.veteran = veteran;
        this.freshBlood = freshBlood;
        this.inactive = inactive;
        this.miniSeries = miniSeries;
    }

    public string leagueId { get; set; }
    public string summonerId { get; set; }
    public string summonerName { get; set; }
    public string queueType { get; set; }
    public string tier { get; set; }
    public string rank { get; set; }
    public int leaguePoints { get; set; }
    public int wins { get; set; }
    public int losses { get; set; }
    public bool hotStreak { get; set; }
    public bool veteran { get; set; }
    public bool freshBlood { get; set; }
    public bool inactive { get; set; }
    public MiniSeriesDto miniSeries { get; set; }
}
