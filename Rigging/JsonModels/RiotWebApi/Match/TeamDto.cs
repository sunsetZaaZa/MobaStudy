namespace MobaGains.Rigging.JsonModels.RiotWebApi.Match;

public class TeamDto
{
    public TeamDto(List<BanDto> bans, ObjectiveDto objectives, int teamId, bool win)
    {
        this.bans = bans;
        this.objectives = objectives;
        this.teamId = teamId;
        this.win = win;
    }

    public List<BanDto> bans { get; set; }
    public ObjectiveDto objectives { get; set; }
    public int teamId { get; set; }
    public bool win { get; set; }
}
