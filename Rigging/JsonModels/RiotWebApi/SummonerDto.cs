namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class SummonerDto
{
    public SummonerDto(string accountId, int profileIconId, long revisionDate, string name, string id, string puuid, long summonerLevel)
    {
        this.accountId = accountId;
        this.profileIconId = profileIconId;
        this.revisionDate = revisionDate;
        this.name = name;
        this.id = id;
        this.puuid = puuid;
        this.summonerLevel = summonerLevel;
    }

    public string accountId { get; set; }
    public int profileIconId { get; set; }
    public long revisionDate { get; set; }
    public string name { get; set; } //Summoner Name w/o TagLine
    public string id { get; set; } //Summoner ID
    public string puuid { get; set; }
    public long summonerLevel { get; set; }
}
