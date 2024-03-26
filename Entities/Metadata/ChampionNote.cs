using MobaGains.Rigging.Enum;

namespace MobaGains.Entities.Metadata;

public class ChampionNote
{
    public ChampionNote(Guid id, int championId, NoteType type, string description)
    {
        this.id = id;
        this.championId = championId;
        this.type = type;
        this.description = description;
    }

    public Guid id { get; set; }
    public int championId { get; set; }
    public NoteType type { get; set; }
    public string description { get; set; }

}
