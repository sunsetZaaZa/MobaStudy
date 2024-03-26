namespace MobaGains.Entities.LegendsDto.Match;

public class PerkStyle
{
    public PerkStyle(Guid matchGuid, string puuid, string description, List<PerkStyleSelection> selections, int style)
    {
        this.matchGuid = matchGuid;
        this.puuid = puuid;
        this.description = description;
        this.selections = selections;
        this.style = style;
    }

    public Guid matchGuid { get; set; } //Foreign Key of Match & Primary Key for PerkStyle
    public string puuid { get; set; } //Primary Key
    public string description { get; set; }
    public List<PerkStyleSelection> selections { get; set; }
    public int style { get; set; }
}
