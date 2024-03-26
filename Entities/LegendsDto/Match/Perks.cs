namespace MobaGains.Entities.LegendsDto.Match;

public class Perks
{
    public Perks(Guid matchGuid, string puuid, int defense, int flex, int offense, List<PerkStyle> styles)
    {
        this.matchGuid = matchGuid;
        this.puuid = puuid;
        this.defense = defense;
        this.flex = flex;
        this.offense = offense;
        this.styles = styles;
    }

    public Guid matchGuid { get; set; } //Foreign Key of Match & Primary Key for Perks
    public string puuid { get; set; } //Primary Key
    public int defense { get; set; } //PerkStats
    public int flex { get; set; } //PerkStats
    public int offense { get; set; } //PerkStats
    public List<PerkStyle> styles { get; set; }
}
