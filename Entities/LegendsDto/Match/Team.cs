namespace MobaGains.Entities.LegendsDto.Match;

public class Team
{
    public Team(Guid matchGuid, int teamId, List<Ban> bans, bool first, int kills, bool win)
    {
        this.matchGuid = matchGuid;
        this.teamId = teamId;
        this.bans = bans;
        this.first = first;
        this.kills = kills;
        this.win = win;
    }

    public Guid matchGuid { get; set; } //Foreign Key of Match & Primary Key of Team
    public int teamId { get; set; } //Primary Key
    public List<Ban> bans { get; set; }
    public bool first { get; set; } //ObjectiveDto
    public int kills { get; set; } //ObjectiveDto
    public bool win { get; set; }
}
