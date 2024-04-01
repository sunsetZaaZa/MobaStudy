namespace MobaGains.Entities.Gameplay;

public class TailoredLoadout
{
    public TailoredLoadout(Guid indexer, Guid? playstyleGuid, Guid? gearLayoutGuid, Guid? runeSetGuid, bool wip, bool active, bool soloLoadout, 
                            List<int> championId, string name, int spell1Id , int spell2Id, DateTime createdOn, DateTime? sidelined, 
                            string activePatchVersion, List<string> viablePatchVersions, int wins, int losses)
    {
        this.indexer = indexer;
        this.playstyleGuid = playstyleGuid;
        this.gearLayoutGuid = gearLayoutGuid;
        this.runeSetGuid = runeSetGuid;
        this.wip = wip;
        this.active = active;
        this.soloLoadout = soloLoadout;
        this.championId = championId;
        this.name = name;
        this.spell1Id = spell1Id;
        this.spell2Id = spell2Id;
        this.createdOn = createdOn;
        this.sidelined = sidelined;
        this.activePatchVersion = activePatchVersion;
        this.viablePatchVersions = viablePatchVersions;
        this.wins = wins;
        this.losses = losses;
    }

    public Guid indexer { get; set; }
    public Guid? playstyleGuid { get; set; }
    public Guid? gearLayoutGuid { get; set; }
    public Guid? runeSetGuid { get; set; }
    public bool wip { get; set; }
    public bool active { get; set; }
    public bool soloLoadout { get; set; }
    public List<int> championId { get; set; }
    public string name { get; set; }
    public int spell1Id { get; set; }
    public int spell2Id { get; set; }
    public DateTime createdOn { get; set; }
    public DateTime? sidelined { get; set; }
    public string activePatchVersion { get; set; }
    public List<string> viablePatchVersions { get; set; }
    public int wins { get; set; }
    public int losses { get; set; }
}
