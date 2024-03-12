namespace MobaGains.Rigging.JsonModels;

public class PlatformDataDto
{
    public PlatformDataDto(string id, string name, List<string> locales, List<StatusDto> maintenances, List<StatusDto> incidents)
    {
        this.id = id;
        this.name = name;
        this.locales = locales;
        this.maintenances = maintenances;
        this.incidents = incidents;
    }

    public string id { get; set; }
    public string name { get; set; }
    public List<string> locales { get; set; }
    public List<StatusDto> maintenances { get; set; }
    public List<StatusDto> incidents { get; set; }
}
