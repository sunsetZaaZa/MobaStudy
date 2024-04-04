namespace MobaGains.Entities.Metadata.Item;

public class ItemAttribute
{
    public ItemAttribute(int itemId, string name, int patchVersion, bool activeEffect, string description)
    {
        this.itemId = itemId;
        this.name = name;
        this.patchVersion = patchVersion;
        this.activeEffect = activeEffect;
        this.description = description;
    }

    public int itemId { get; set; } //Primary key
    public string name { get; set; } //Primary key
    public int patchVersion { get; set; }
    public bool activeEffect { get; set; }
    public string description { get; set; } // \n separation of sentences 
}
