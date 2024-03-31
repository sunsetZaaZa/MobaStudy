namespace MobaGains.Entities.LegendsDto;

public class LeagueList
{
    public LeagueList(Guid leagueGuid, string leagueId, List<LeagueItem> entries, string tier, string name, string queue)
    {
        this.leagueGuid = leagueGuid;
        this.leagueId = leagueId;
        this.entries = entries;
        this.tier = tier;
        this.name = name;
        this.queue = queue;
    }

    public Guid leagueGuid { get; set; }
    public string leagueId { get; set; }
    public List<LeagueItem> entries { get; set; }
    public string tier { get; set; }
    public string name { get; set; }
    public string queue { get; set; }
}
