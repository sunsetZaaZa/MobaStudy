using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public struct AttributeRatings
{
    public AttributeRatings(int championId, int damage, int toughness, int control, int mobility,
                            int utility, int abilityReliance, int difficulty)
    {
        this.championId = championId;
        this.damage = damage;
        this.toughness = toughness;
        this.control = control;
        this.mobility = mobility;
        this.utility = utility;
        this.abilityReliance = abilityReliance;
        this.difficulty = difficulty;
    }

    public int championId { get; set; } //Primary Key
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
                    List<ChampionRoleIndexer> roles, AttributeRatings attributeRatings, List<ChampStatMetadata> stats, ChampionPassive passive,
                    ChampionAbility ability_Q, ChampionAbility ability_W, ChampionAbility ability_E, ChampionAbility ability_R, string releaseDate, string releasePatch, 
                    string patchLastChanged)
    {
        this.championId = championId;
        this.name = name;
        this.title = title;
        this.fullName = fullName;
        this.primaryResource = primaryResource;
        this.passiveResource = passiveResource;
        this.roles = roles;
        this.attributeRatings = attributeRatings;
        this.stats = stats;
        this.passive = passive;
        this.ability_Q = ability_Q;
        this.ability_W = ability_W;
        this.ability_E = ability_E;
        this.ability_R = ability_R;
        this.releaseDate = releaseDate;
        this.releasePatch = releasePatch;
        this.patchLastChanged = patchLastChanged;
    }

    public string championId { get; set; } //Primary Key
    public string name { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public CharacterResourceIndexer primaryResource { get; set; }
    public CharacterResourceIndexer? passiveResource { get; set; }
    public List<ChampionRoleIndexer> roles { get; set; }
    public AttributeRatings attributeRatings { get; set; }
    public List<ChampStatMetadata> stats { get; set; }
    public ChampionPassive passive { get; set; }
    public ChampionAbility ability_Q { get; set; }
    public ChampionAbility ability_W { get; set; }
    public ChampionAbility ability_E { get; set; }
    public ChampionAbility ability_R { get; set; }
    public string releaseDate { get; set; }
    public string releasePatch { get; set; }
    public string patchLastChanged { get; set; }
}