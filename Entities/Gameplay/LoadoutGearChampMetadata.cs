namespace MobaGains.Entities.Gameplay;

public class LoadoutGearChampMetadata
{
    public LoadoutGearChampMetadata(Guid indexer, string? activePatchVersion, List<string>? viablePatchVersions, 
                                        DateTime createdOn, DateTime? sidelined)
    {
        this.indexer = indexer;
        this.activePatchVersion = activePatchVersion;
        this.viablePatchVersions = viablePatchVersions;
        this.createdOn = createdOn;
        this.sidelined = sidelined;
    }
    public Guid indexer { get; set; }
    public string? activePatchVersion { get; set; }
    public List<string>? viablePatchVersions { get; set; }
    public DateTime createdOn { get; set; }
    public DateTime? sidelined { get; set; }
}
