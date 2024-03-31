using MobaGains.Rigging.JsonModels.RiotWebApi;

namespace MobaGains.Entities.LegendsDto;

public class LeagueItem
{
    public LeagueItem(Guid leagueGuid, string summonerId, bool freshBlood, int wins, string summonerName,
                        int minilosses, string miniProgress, int miniTarget, int miniWins, bool inactive,
                        bool veteran, bool hotStreak, string rank, int leaguePoints, int losses)
    {
        this.leagueGuid = leagueGuid;
        this.summonerId = summonerId;
        this.freshBlood = freshBlood;
        this.wins = wins;
        this.summonerName = summonerName;
        this.minilosses = minilosses;
        this.miniProgress = miniProgress;
        this.miniTarget = miniTarget;
        this.miniWins = miniWins;
        this.inactive = inactive;
        this.veteran = veteran;
        this.hotStreak = hotStreak;
        this.rank = rank;
        this.leaguePoints = leaguePoints;
        this.losses = losses;
    }

    public Guid leagueGuid { get; set; } //Foreign Key of LeagueList & Primary Key to LeagueItem
    public string summonerId { get; set; } // Primary Key to LeagueItem
    public bool freshBlood { get; set; }
    public int wins { get; set; }
    public string summonerName { get; set; }
    public int minilosses { get; set; } // MiniSeries
    public string miniProgress { get; set; } // MiniSeries
    public int miniTarget { get; set; } // MiniSeries
    public int miniWins { get; set; } // MiniSeries
    public bool inactive { get; set; }
    public bool veteran { get; set; }
    public bool hotStreak { get; set; }
    public string rank { get; set; }
    public int leaguePoints { get; set; }
    public int losses { get; set; }
}
