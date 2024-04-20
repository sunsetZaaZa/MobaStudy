namespace MobaGains.Entities.Gameplay;

public class Playstyle
{
    public Playstyle(int indexer, string name, string? subStyle)
    {
        this.indexer = indexer;
        this.name = name;
        this.subStyle = subStyle;
    }

    public int indexer { get; set; } //Primary Key
    public string name { get; set; }
    public string? subStyle { get; set; }
}
