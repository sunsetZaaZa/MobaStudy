namespace MobaGains.Rigging.JsonModels.LCU;

public class ValidateRunePage
{
    public ValidateRunePage(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public int id { get; set; }
    public string name { get; set; }
}
