namespace MobaGains.Entities.Metadata.Rigging;

public class Patches
{
    public Patches(int indexer, string textRepresentation, int comparator)
    {
        this.indexer = indexer;
        this.textRepresentation = textRepresentation;
        this.comparator = comparator;
    }

    public int indexer { get; set; } //Primary Key
    public string textRepresentation {  get; set; }
    public int comparator { get; set; }
}
