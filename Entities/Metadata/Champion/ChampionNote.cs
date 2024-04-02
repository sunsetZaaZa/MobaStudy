using MobaGains.Rigging.Enum;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampionNote
{
    public ChampionNote(int championId, int makeshiftOrder, NoteType type, string description)
    {
        this.championId = championId;
        this.makeshiftOrder = makeshiftOrder;
        this.type = type;
        this.description = description;
    }

    public int championId { get; set; } //Primary Key
    public int makeshiftOrder { get; set; } //Primary Key
    public NoteType type { get; set; }
    public string description { get; set; }
}