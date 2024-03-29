namespace MobaGains.Rigging.JsonModels.LCU;

public class RuneSet
{
    public RuneSet(List<int> autoModifiedSelections, bool current, int id, bool isActive, bool isDeletable, bool isValid, int lastModified, string name, int order, int primaryStyleId, 
                    List<int> selectedPerkIds, int subStyleId)
    {
        this.autoModifiedSelections = autoModifiedSelections;
        this.current = current;
        this.id = id;
        this.isActive = isActive;
        this.isDeletable = isDeletable;
        this.isValid = isValid;
        this.lastModified = lastModified;
        this.name = name;
        this.order = order;
        this.primaryStyleId = primaryStyleId;
        this.selectedPerkIds = selectedPerkIds;
        this.subStyleId = subStyleId;
    }

    public List<int> autoModifiedSelections { get; set; }
    public bool current { get; set; }
    public int id { get; set; }
    public bool isActive { get; set; }
    public bool isDeletable { get; set; }
    public bool isValid { get; set; }
    public int lastModified { get; set; }
    public string name { get; set; }
    public int order { get; set; }
    public int primaryStyleId { get; set; }
    public List<int> selectedPerkIds { get; set; }
    public int subStyleId { get; set; }
}
