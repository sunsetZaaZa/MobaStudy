namespace MobaGains.Entities.Metadata;

public class SummonerSpell
{
    public SummonerSpell(int id, string name, string description, int summonerLevel, int cooldown, List<string> gameModes, string iconName)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.summonerLevel = summonerLevel;
        this.cooldown = cooldown;
        this.gameModes = gameModes;
        this.iconName = iconName;
    }

    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int summonerLevel { get; set; }
    public int cooldown { get; set; }
    public List<string> gameModes { get; set; }
    public string iconName { get; set; }
}
