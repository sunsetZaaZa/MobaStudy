namespace MobaGains.Rigging.Utilities.Metadata;

public class MapDetails
{
    public MapDetails(string id, string name, string description, string mapStringId)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        this.mapStringId = mapStringId;
    }

    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string mapStringId { get; set; }
}
