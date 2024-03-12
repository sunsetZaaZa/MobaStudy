namespace MobaGains.Rigging.Configs;

public class APIConfig
{
    public APIConfig(string region, string language, string apiUri, string userAgent, string acceptLanguage, string riotKey)
    {
        this.region = region;
        this.language = language;
        this.apiUri = apiUri;
        this.userAgent = userAgent;
        this.acceptLanguage = acceptLanguage;
        this.riotKey = riotKey;
    }

    public required string region { get; set; }
    public required string language { get; set; }
    public required string apiUri { get; set; }
    public string userAgent { get; set; }
    public string acceptLanguage { get; set; }
    public string riotKey { get; set; }
}
