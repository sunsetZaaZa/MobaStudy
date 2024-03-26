namespace MobaGains.Rigging.JsonModels.RiotWebApi.Match;

public class PerkStatsDto
{
    public PerkStatsDto(int defense, int flex, int offense)
    {
        this.defense = defense;
        this.flex = flex;
        this.offense = offense;
    }

    public int defense { get; set; }
    public int flex { get; set; }
    public int offense { get; set; }
}
