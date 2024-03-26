namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class ChallengePercentilesDto
{
    public ChallengePercentilesDto(Dictionary<int, Dictionary<string, double>> info)
    {
        this.info = info;
    }
    public Dictionary<int, Dictionary<string, double>> info { get; set; }
}
