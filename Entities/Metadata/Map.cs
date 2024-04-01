namespace MobaGains.Entities.Metadata;

public class Map
{
    public Map(int id, string name, string description)
    {
        this.id = id;
        this.name = name;
        this.description = description;
    }

    public int id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
}
