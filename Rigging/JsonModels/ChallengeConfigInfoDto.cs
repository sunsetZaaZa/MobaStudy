namespace MobaGains.Rigging.JsonModels;

public class ChallengeConfigInfoDto
{
    public ChallengeConfigInfoDto(long id, Dictionary<string, Dictionary<string, string>> localizedNames, string state, string? tracking, long startTimestamp, long endTimestamp, bool leaderboard, Dictionary<string, double> thresholds)
    {
        this.id = id;
        this.localizedNames = localizedNames;
        this.state = state;
        this.tracking = tracking;
        this.startTimestamp = startTimestamp;
        this.endTimestamp = endTimestamp;
        this.leaderboard = leaderboard;
        this.thresholds = thresholds;
    }

    public long id { get; set; }
    public Dictionary<string, Dictionary<string, string>> localizedNames { get; set; }
    public string state { get; set; }
    public string? tracking { get; set; }
    public long startTimestamp { get; set; }
    public long endTimestamp { get; set; }
    public bool leaderboard { get; set; }
    public Dictionary<string, double> thresholds {  get; set; }
}
