using System.Diagnostics.CodeAnalysis;

namespace MobaGains.Rigging.Configs;

public class MetadataConfig
{
    [SetsRequiredMembers]
    public MetadataConfig(string versionsUri, string itemUri, string championUri)
    {
        this.versionsUri = versionsUri;
        this.itemUri = itemUri;
        this.championUri = championUri;
    }

    public required string versionsUri { get; set; }
    public required string itemUri { get; set; }
    public required string championUri { get; set; }
}
