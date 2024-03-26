using MobaGains.Rigging.Enum;

namespace MobaGains.Entities.Metadata;

public class ChampionPassive
{
    public ChampionPassive(string championId, string name, string description, List<Tuple<ChampPassive, string>> ability)
    {
        this.championId = championId;
        this.name = name;
        this.description = description;
        this.ability = ability;
    }

    public string championId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public List<Tuple<ChampPassive, string>> ability { get; set; } //name, stat
}
