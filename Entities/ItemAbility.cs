namespace MobaGains.Entities;

public class ItemAbility
{
    public ItemAbility(string itemId, List<Tuple<string, string>> activeAbility, List<Tuple<string, string>> passiveAbility)
    {
        this.itemId = itemId;
        this.activeAbility = activeAbility;
        this.passiveAbility = passiveAbility;
    }

    public string itemId { get; set; }
    public List<Tuple<string, string>> activeAbility {  get; set; }
    public List<Tuple<string, string>> passiveAbility { get; set; }
}
