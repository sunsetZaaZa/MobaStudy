namespace MobaGains.Entities.Gameplay;

public class LoadoutGearChampMetadata
{
    public LoadoutGearChampMetadata(Guid indexer, int activePatchIndexer, DateTime createdOn, DateTime? loadedInGame, DateTime? sidelined)
    {
        this.indexer = indexer;
        this.activePatchIndexer = activePatchIndexer;
        this.loadedInGame = loadedInGame;
        this.createdOn = createdOn;
        this.sidelined = sidelined;
    }
    public Guid indexer { get; set; }
    public int activePatchIndexer { get; set; }
    public DateTime? loadedInGame { get; set; }
    public DateTime createdOn { get; set; }
    public DateTime? sidelined { get; set; }
}
