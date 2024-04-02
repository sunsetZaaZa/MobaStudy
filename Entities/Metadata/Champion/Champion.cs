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
    public Champion(string championId, string name, string title, string fullName, CharacterResourceIndexer primaryResource, CharacterResourceIndexer? passiveResource,
                    List<ChampionRoleIndexer> roles, ChampionPassive passive, AttributeRatings attributeRatings, List<ChampStatMetadata> stats)
    {
        this.championId = championId;
        this.name = name;
        this.title = title;
        this.fullName = fullName;
        this.primaryResource = primaryResource;
        this.passiveResource = passiveResource;
        this.roles = roles;
        this.passive = passive;
        this.attributeRatings = attributeRatings;
        this.stats = stats;
    }

    public string championId { get; set; } //Primary Key
    public string name { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public CharacterResourceIndexer primaryResource { get; set; }
    public CharacterResourceIndexer? passiveResource { get; set; }
    public List<ChampionRoleIndexer> roles { get; set; }
    public ChampionPassive passive { get; set; }
    public AttributeRatings attributeRatings { get; set; }
    public List<ChampStatMetadata> stats { get; set; }
}