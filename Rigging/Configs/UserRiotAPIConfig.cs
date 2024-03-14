using System.Diagnostics.CodeAnalysis;

namespace MobaGains.Rigging.Configs;

public class UserRiotAPIConfig
{
    [SetsRequiredMembers]
    public UserRiotAPIConfig(string region, string apiUri, string userAgent, string acceptLanguage, string riotKey)
    {
        this.region = region;
        this.apiUri = apiUri;
        this.userAgent = userAgent;
        this.acceptLanguage = acceptLanguage;
        this.riotKey = riotKey;
    }

    public required string region { get; set; }
    public required string apiUri { get; set; }
    public required string userAgent { get; set; }
    public required string acceptLanguage { get; set; }
    public required string riotKey { get; set; }
}
