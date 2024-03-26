namespace MobaGains.Entities.LegendsDto;

public class LeagueList
{

    public Guid leagueGuid { get; set; }
    public string leagueId { get; set; }
    public List<LeagueItem> entries { get; set; }
    public string tier { get; set; }
    public string name { get; set; }
    public string queue { get; set; }
}
