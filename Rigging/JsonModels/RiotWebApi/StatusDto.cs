namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class StatusDto
{
    public StatusDto(int id, string maintenance_status, string incident_severity, List<ContentDto> titles, List<UpdateDto> updates, string created_at, string archive_at, string updated_at, List<string> platforms)
    {
        this.id = id;
        this.maintenance_status = maintenance_status;
        this.incident_severity = incident_severity;
        this.titles = titles;
        this.updates = updates;
        this.created_at = created_at;
        this.archive_at = archive_at;
        this.updated_at = updated_at;
        this.platforms = platforms;
    }

    public int id { get; set; }
    public string maintenance_status { get; set; }
    public string incident_severity { get; set; }
    public List<ContentDto> titles { get; set; }
    public List<UpdateDto> updates { get; set; }
    public string created_at { get; set; }
    public string archive_at { get; set; }
    public string updated_at { get; set; }
    public List<string> platforms { get; set; }
}
