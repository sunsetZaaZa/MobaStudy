namespace MobaGains.Entities.LegendsDto.Match;

public class PerkStyleSelection
{
    public PerkStyleSelection(Guid matchGuid, string puuid, int perk, int? var1, int? var2, int? var3)
    {
        this.matchGuid = matchGuid;
        this.puuid = puuid;
        this.perk = perk;
        this.var1 = var1;
        this.var2 = var2;
        this.var3 = var3;
    }

    public Guid matchGuid { get; set; } //Foreign Key of Match & Primary Key for PerkStyleSelection
    public string puuid { get; set; } //Primary Key
    public int perk { get; set; }
    public int? var1 { get; set; }
    public int? var2 { get; set; }
    public int? var3 { get; set; }
}
