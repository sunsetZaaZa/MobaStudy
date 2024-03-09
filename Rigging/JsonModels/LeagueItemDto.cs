namespace MobaGains.Rigging.JsonModels;

public class LeagueItemDto
{
    public LeagueItemDto(bool freshBlood, int wins, string summonerName, MiniSeriesDto miniSeries, bool inactive, bool veteran, bool hotStreak, string rank, int leaguePoints, int losses, string summonerId)
    {
        this.freshBlood = freshBlood;
        this.wins = wins;
        this.summonerName = summonerName;
        this.miniSeries = miniSeries;
        this.inactive = inactive;
        this.veteran = veteran;
        this.hotStreak = hotStreak;
        this.rank = rank;
        this.leaguePoints = leaguePoints;
        this.losses = losses;
        this.summonerId = summonerId;
    }

    public bool freshBlood { get; set; }
    public int wins { get; set; }
    public string summonerName { get; set; }
    public MiniSeriesDto miniSeries { get; set; }
    public bool inactive { get; set; }
    public bool veteran { get; set; }
    public bool hotStreak { get; set; }
    public string rank { get; set; }
    public int leaguePoints { get; set; }
    public int losses { get; set; }
    public string summonerId { get; set; }
}
