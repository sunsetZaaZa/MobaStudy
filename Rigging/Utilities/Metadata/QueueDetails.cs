namespace MobaGains.Rigging.Utilities.Metadata;

public class QueueDetails
{
    public QueueDetails(string id, string name, string shortName, string description, string detailedDescription)
    {
        this.id = id;
        this.name = name;
        this.shortName = shortName;
        this.description = description;
        this.detailedDescription = detailedDescription;    }
    
    public required string id { get; set; }
    public required string name { get; set; }
    public required string shortName { get; set; }
    public required string description { get; set; }
    public required string detailedDescription { get; set; }
}
