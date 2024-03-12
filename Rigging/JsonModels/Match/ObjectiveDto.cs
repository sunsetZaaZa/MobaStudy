namespace MobaGains.Rigging.JsonModels.Match;

public class ObjectiveDto
{
    public ObjectiveDto(bool first, int kills)
    {
        this.first = first;
        this.kills = kills;
    }

    public bool first { get; set; }
    public int kills { get; set; }
}
