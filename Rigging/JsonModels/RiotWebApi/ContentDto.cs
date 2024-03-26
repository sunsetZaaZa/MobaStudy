namespace MobaGains.Rigging.JsonModels.RiotWebApi;

public class ContentDto
{
    public ContentDto(string locale, string content)
    {
        this.locale = locale;
        this.content = content;
    }

    public string locale { get; set; }
    public string content { get; set; }
}
