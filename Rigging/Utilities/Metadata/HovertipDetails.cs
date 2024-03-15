namespace MobaGains.Rigging.Utilities.Metadata;

public class HovertipDetails
{
    public HovertipDetails(string key, string value)
    {
        this.key = key;
        this.value = value;
    }

    public string key { get; set; }
    public string value { get; set; }
}
