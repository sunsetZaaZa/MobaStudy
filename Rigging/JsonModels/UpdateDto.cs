namespace MobaGains.Rigging.JsonModels;

public class UpdateDto
{
    public UpdateDto(int id, string author, string publish, List<string> publish_locations, List<ContentDto> translations, string created_at, string updated_at)
    {
        this.id = id;
        this.author = author;
        this.publish = publish;
        this.publish_locations = publish_locations;
        this.translations = translations;
        this.created_at = created_at;
        this.updated_at = updated_at;
    }

    public int id { get; set; }
    public string author { get; set; }
    public string publish { get; set; }
    public List<string> publish_locations { get; set; }
    public List<ContentDto> translations { get; set; }
    public string created_at { get; set; }
    public string updated_at { get; set; }
}
