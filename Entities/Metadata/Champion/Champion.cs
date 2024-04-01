using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public struct AttributeRatings
{
    public AttributeRatings(int damage, int toughness, int control, int mobility,
                            int utility, int abilityReliance, int difficulty)
    {
        this.damage = damage;
        this.toughness = toughness;
        this.control = control;
        this.mobility = mobility;
        this.utility = utility;
        this.abilityReliance = abilityReliance;
        this.difficulty = difficulty;
    }

    public int damage { get; set; }
    public int toughness { get; set; }
    public int control { get; set; }
    public int mobility { get; set; }
    public int utility { get; set; }
    public int abilityReliance { get; set; }
    public int difficulty { get; set; }
}

public class Champion
{
    public Champion(string championId, string name, string title, string fullName, CharacterResource costType, List<ChampionRole> roles, List<ChampionPassive> passives, AttributeRatings attributeRatings)
    {
        this.championId = championId;
        this.name = name;
        this.title = title;
        this.fullName = fullName;
        this.costType = costType;
        this.roles = roles;
        this.passives = passives;
        this.attributeRatings = attributeRatings;
    }

    public string championId { get; set; }
    public string name { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public CharacterResource costType { get; set; }
    public List<ChampionRole> roles { get; set; }
    public List<ChampionPassive> passives { get; set; }
    public AttributeRatings attributeRatings { get; set; }
}