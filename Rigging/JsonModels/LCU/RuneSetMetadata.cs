namespace MobaGains.Rigging.JsonModels.LCU;

public class RuneSetMetadata
{
    public RuneSetMetadata(bool canAddCustomPage, int customPageCount, bool isCustomPageCreationUnlocked, int ownedPageCount)
    {
        this.canAddCustomPage = canAddCustomPage;
        this.customPageCount = customPageCount;
        this.isCustomPageCreationUnlocked = isCustomPageCreationUnlocked;
        this.ownedPageCount = ownedPageCount;
    }

    public bool canAddCustomPage { get; set; }
    public int customPageCount { get; set; }
    public bool isCustomPageCreationUnlocked { get; set; }
    public int ownedPageCount { get; set; }
}
