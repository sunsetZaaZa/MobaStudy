namespace MobaGains.Rigging.Utilities;

public interface IGameplayModels
{
    public int Runspeed();
    public int CooldownReduction();
    public int ManaReduction();
    public int HealthIncrease();
    public int ArmorIncrease();
    public int MagicResist();
    public int ArmorPen();
    public int Lethality();
    public int HealthRegen();
    public int ManaRegen();
    public List<ItemAbility> FindItemsActivation();
    public List<ItemAbility> FindItemsPassive();
}

public class GameplayModels
{

}
