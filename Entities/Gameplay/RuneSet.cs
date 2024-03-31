namespace MobaGains.Entities.Gameplay;

public class RuneSet
{
    public RuneSet(Guid indexer, string? name, Guid? playstyleGuid, int primaryStyleId, 
                    int secondaryStyleId, List<int> styleIds)
    {
        this.indexer = indexer;
        this.name = name;
        this.playstyleGuid = playstyleGuid;
        this.primaryStyleId = primaryStyleId;
        this.secondaryStyleId = secondaryStyleId;
        this.styleIds = styleIds;
    }

    public Guid indexer { get; set; }
    public string? name { get; set; }
    public Guid? playstyleGuid { get; set; }
    public int primaryStyleId { get; set; }
    public int secondaryStyleId { get; set; }
    public List<int> styleIds { get; set; }
}
