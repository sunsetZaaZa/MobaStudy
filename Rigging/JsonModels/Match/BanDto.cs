namespace MobaGains.Rigging.JsonModels.Match;

public class BanDto
{
    public BanDto(int championId, int pickTurn)
    {
        this.championId = championId;
        this.pickTurn = pickTurn;
    }

    public int championId { get; set; }
    public int pickTurn { get; set; }
}
