namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class LeagueListDto
{
    public string leagueId { get; set; }
    public List<LeagueItemDto> entries { get; set; }
    public string tier { get; set; }
    public string name { get; set; }
    public string queue { get; set; }
}
