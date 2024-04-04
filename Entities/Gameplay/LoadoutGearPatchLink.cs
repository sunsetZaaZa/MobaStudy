using System.Security.Policy;

namespace MobaGains.Entities.Gameplay;

public class LoadoutGearPatchLink
{
    public LoadoutGearPatchLink(Guid loadoutGearGuid, int patchesIndexer)
    {
        this.loadoutGearGuid = loadoutGearGuid;
        this.patchesIndexer = patchesIndexer;
    }

    public Guid loadoutGearGuid { get; set; } //Primary Key
    public int patchesIndexer { get; set; } //Primary Key
}
