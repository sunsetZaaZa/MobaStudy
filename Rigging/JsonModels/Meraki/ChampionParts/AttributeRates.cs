namespace MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

public struct AttributeRates
{
    public AttributeRates(int damage, int toughness, int control, int mobility, int utility, int abilityReliance, int difficulty)
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
