using MobaGains.Rigging.Enum;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampionNote
{
    public ChampionNote(Guid indexer, int championId, NoteType type, string description)
    {
        this.indexer = indexer;
        this.championId = championId;
        this.type = type;
        this.description = description;
    }

    public Guid indexer { get; set; }
    public int championId { get; set; }
    public NoteType type { get; set; }
    public string description { get; set; }
}