using MobaGains.Rigging.Enum;
using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata;

public struct AttributeRatings
{
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
    public string id { get; set; }
    public string name { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public CharacterResource costType { get; set; }
    public List<ChampionRole> roles { get; set; }
    public List<ChampionPassive> passives { get; set; }
    public AttributeRatings attributeRatings { get; set; }

}
