using System.Data;

namespace MobaGains.Entities.LegendsDto.Match;

public class Match
{
    public Match(Guid matchGuid, string dataVersion, string matchId, Info info)
    {
        this.matchGuid = matchGuid;
        this.dataVersion = dataVersion;
        this.matchId = matchId;
        this.info = info;
    }

    public Guid matchGuid { get; set; } //Primary Key
    public string dataVersion { get; set; }
    public string matchId { get; set; }
    public Info info { get; set; }
}
