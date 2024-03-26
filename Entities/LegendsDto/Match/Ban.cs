namespace MobaGains.Entities.LegendsDto.Match;

public class Ban
{
    public Ban(Guid matchGuid, int championId, int pickTurn)
    {
        this.matchGuid = matchGuid;
        this.championId = championId;
        this.pickTurn = pickTurn;
    }

    public Guid matchGuid { get; set; } //Foreign Key of Match & Primary Key of Ban
    public int championId { get; set; } //Primary Key
    public int pickTurn { get; set; }
}
