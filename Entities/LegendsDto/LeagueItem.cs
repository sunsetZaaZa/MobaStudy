using MobaGains.Rigging.JsonModels.RiotWebApi;

namespace MobaGains.Entities.LegendsDto;

public class LeagueItem
{

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
