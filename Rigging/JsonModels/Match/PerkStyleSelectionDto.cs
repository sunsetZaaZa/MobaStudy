namespace MobaGains.Rigging.JsonModels.Match;

public class PerkStyleSelectionDto
{
    public PerkStyleSelectionDto(int perk, int var1, int var2, int var3)
    {
        this.perk = perk;
        this.var1 = var1;
        this.var2 = var2;
        this.var3 = var3;
    }

    public int perk { get; set; }
    public int var1 { get; set; }
    public int var2 { get; set; }
    public int var3 { get; set; }
}
