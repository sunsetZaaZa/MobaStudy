namespace MobaGains.Entities;

public class ChampionPassive
{

    public string championId { get; set; }
    public string name {  get; set; }
    public string description { get; set; }
    public List<Tuple<string, string>> ability { get; set; } //name, stat
}
