namespace MobaGains.Entities.Gameplay;

public class LoadoutGearPatchLink
{
    public LoadoutGearPatchLink(Guid loadoutGearGuid, int trackedPatchIndex, int createdPatchIndex, List<int> viablePatchIndexes)
    {
        this.loadoutGearGuid = loadoutGearGuid;
        this.trackedPatchIndex = trackedPatchIndex;
        this.createdPatchIndex = createdPatchIndex;
        this.viablePatchIndexes = viablePatchIndexes;
    }

    public Guid loadoutGearGuid { get; set; } //Primary Key
    public int trackedPatchIndex { get; set; } //Primary Key
    public int createdPatchIndex { get; set; }
    public List<int> viablePatchIndexes { get; set; }
}
