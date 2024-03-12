namespace MobaGains.Rigging.JsonModels.Match;

public class PerkStyleDto
{
    public PerkStyleDto(string description, List<PerkStyleSelectionDto> selections, int style)
    {
        this.description = description;
        this.selections = selections;
        this.style = style;
    }

    public string description { get; set; }
    public List<PerkStyleSelectionDto> selections { get; set; }
    public int style { get; set; }
}
