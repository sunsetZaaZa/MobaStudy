namespace MobaGains.Entities.Gameplay;

public class Playstyle
{
    public Playstyle(Guid indexer, string name)
    {
        this.indexer = indexer;
        this.name = name;
    }

    public Guid indexer { get; set; }
    public string name { get; set; }
}
