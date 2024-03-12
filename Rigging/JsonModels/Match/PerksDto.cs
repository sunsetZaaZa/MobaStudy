namespace MobaGains.Rigging.JsonModels.Match;

public class PerksDto
{
    public PerksDto(PerkStatsDto statsPerks, List<PerkStyleDto> styles)
    {
        this.statsPerks = statsPerks;
        this.styles = styles;
    }

    public PerkStatsDto statsPerks { get; set; }
    public List<PerkStyleDto> styles { get; set; }
}
