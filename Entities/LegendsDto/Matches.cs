namespace MobaGains.Entities.LegendsDto;

public class Matches
{
    public Matches(Guid id, string matchIds, DateTime? start, DateTime? end, int? queue, string? type, int startIndex, int limit)
    {
        this.id = id;
        this.matchIds = matchIds;
        this.start = start;
        this.end = end;
        this.queue = queue;
        this.type = type;
        this.startIndex = startIndex;
        this.limit = limit;
    }

    public Guid id { get; set; } //Primary Key
    public string matchIds { get; set; } //matchId,matchId,matchId,...,matchId
    public DateTime? start { get; set; }
    public DateTime? end { get; set; }
    public int? queue { get; set; }
    public string? type { get; set; }
    public int startIndex { get; set; }
    public int limit { get; set; }
}
