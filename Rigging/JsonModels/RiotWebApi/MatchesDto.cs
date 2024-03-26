namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class MatchesDto
{
    public MatchesDto(List<string> Ids)
    {
        this.Ids = Ids;
    }

    public List<string> Ids { get; set; }
}
