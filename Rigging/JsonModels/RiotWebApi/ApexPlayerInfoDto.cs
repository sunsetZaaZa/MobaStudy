namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class ApexPlayerInfoDto
{
    public ApexPlayerInfoDto(string puuid, double value, int position)
    {
        this.puuid = puuid;
        this.value = value;
        this.position = position;
    }

    public string puuid { get; set; }
    public double value { get; set; }
    public int position { get; set; }
}