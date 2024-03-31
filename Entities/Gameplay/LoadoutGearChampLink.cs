namespace MobaGains.Entities.Gameplay;

public class LoadoutGearChampLink
{
    public LoadoutGearChampLink(Guid tailoredGearIndexer, int championId, int wins, int losses, bool active, bool wip, 
                                Guid loadoutGearChampMetadataGuid)
    {
        this.tailoredGearIndexer = tailoredGearIndexer;
        this.championId = championId;
        this.wins = wins;
        this.losses = losses;
        this.active = active;
        this.wip = wip;
        this.loadoutGearChampMetadataGuid = loadoutGearChampMetadataGuid;
    }

    public Guid tailoredGearIndexer { get; set; }
    public int championId { get; set; }
    public int wins { get; set; }
    public int losses { get; set; }
    public bool active { get; set; }
    public bool wip { get; set; }
    public Guid loadoutGearChampMetadataGuid { get; set; }
}
