namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class AccountDto
{
    public AccountDto(string puuid, string gameName, string tagLine)
    {
        this.puuid = puuid;
        this.gameName = gameName;
        this.tagLine = tagLine;
    }

    public string puuid { get; set; }
    public string gameName { get; set; }
    public string tagLine { get; set; }
}
