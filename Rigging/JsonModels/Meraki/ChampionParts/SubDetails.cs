namespace MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

public struct SubDetails
{
    public SubDetails(List<float> values, List<string> units)
    {
        this.values = values;
        this.units = units;
    }

    public List<float> values { get; set; }
    public List<string> units { get; set; }
}