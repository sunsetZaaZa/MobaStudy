using JetBrains.Annotations;

namespace MobaGains.Entities.LegendsDto;

public class Account
{
    public Account(Guid accountGuid, string gameName, string tagLine, string? puuid, string? summonerId, string? accountId, int apiKeyHashIndex)
    {
        this.accountGuid = accountGuid;
        this.gameName = gameName;
        this.tagLine = tagLine;
        this.puuid = puuid;
        this.summonerId = summonerId;
        this.accountId = accountId;
        this.apiKeyHashIndex = apiKeyHashIndex;
    }

    public Guid accountGuid { get; set; } //Primary Key
    public string gameName { get; set; }
    public string tagLine { get; set; }
    public string? puuid { get; set; }
    public string? summonerId { get; set; }
    public string? accountId { get; set; }
    public int apiKeyHashIndex { get; set; }
}
