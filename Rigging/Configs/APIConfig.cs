namespace MobaGains.Rigging.Configs;

public class APIConfig
{
    public APIConfig(string region, string language, string apiUri, string userAgent = "", string acceptLanguage = "")
    {
        this.region = region;
        this.language = language;
        this.apiUri = apiUri;
        this.userAgent = userAgent;
        this.acceptLanguage = acceptLanguage;
    }

    public required string region { get; set; }
    public required string language { get; set; }
    public required string apiUri { get; set; }
    public string userAgent { get; set; }
    public string acceptLanguage { get; set; }
}
