namespace MobaGains.Rigging.JsonModels;

public class MiniSeriesDto
{
    public MiniSeriesDto(int losses, string progress, int target, int wins)
    {
        this.losses = losses;
        this.progress = progress;
        this.target = target;
        this.wins = wins;
    }

    public int losses { get; set; }
    public string progress { get; set; }
    public int target { get; set; }
    public int wins { get; set; }
}
