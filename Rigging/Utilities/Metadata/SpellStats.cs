namespace MobaGains.Rigging.Utilities.Metadata;

public class SpellStats
{
    public SpellStats(string id, string name, string description, int summonerLevel, int cooldown, List<string> gameModes, string iconPath)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.summonerLevel = summonerLevel;
        this.cooldown = cooldown;
        this.gameModes = gameModes;
        this.iconPath = iconPath;
    }

    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int summonerLevel { get; set; }
    public int cooldown { get; set; }
    public List<string> gameModes { get; set; }
    public string iconPath { get; set; }
}
