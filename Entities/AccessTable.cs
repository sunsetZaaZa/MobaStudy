namespace MobaGains.Entities;

public class AccessTable
{
    public AccessTable(int id, DateTime added, bool isDev, string apiKeyHash)
    {
        this.id = id;
        this.added = added;
        this.isDev = isDev;
        this.apiKeyHash = apiKeyHash;
    }

    public int id { get; set; }
    public DateTime added { get; set; }
    public bool isDev { get; set; }
    public string apiKeyHash { get; set; }
}
