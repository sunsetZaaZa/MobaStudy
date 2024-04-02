namespace MobaGains.Entities.Metadata.Champion;

public class ChampionPassive
{
    public ChampionPassive(string name, List<string> effects)
    {
        this.name = name;
        this.effects = effects;
    }

    public string name { get; set; }
    public List<string> effects { get; set; }
    public List<Leveling> levels { get; set; }
}