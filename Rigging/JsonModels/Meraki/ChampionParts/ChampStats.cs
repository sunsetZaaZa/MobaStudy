namespace MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

public class ChampStats
{
    public ChampStats(ChampStat health, ChampStat healthRegen, ChampStat mana, ChampStat manaRegen, ChampStat armor, ChampStat magicResistance, ChampStat attackDamage, 
                        ChampStat movespeed, ChampStat acquisitionRadius, ChampStat selectionRadius, ChampStat pathingRadius, ChampStat gameplayRadius, ChampStat criticalStrikeDamage, 
                        ChampStat criticalStrikeDamageModifier, ChampStat attackSpeed, ChampStat attackSpeedRatio, ChampStat attackCastTime, ChampStat attackTotalTime, 
                        ChampStat attackDelayOffset, ChampStat attackRange, ChampStat aramDamageTaken, ChampStat aramDamageDealt, ChampStat aramHealing, ChampStat aramShielding, 
                        ChampStat urfDamageTaken, ChampStat urfDamageDealt, ChampStat urfHealing, ChampStat urfShielding)
    {
        this.health = health;
        this.healthRegen = healthRegen;
        this.mana = mana;
        this.manaRegen = manaRegen;
        this.armor = armor;
        this.magicResistance = magicResistance;
        this.attackDamage = attackDamage;
        this.movespeed = movespeed;
        this.acquisitionRadius = acquisitionRadius;
        this.selectionRadius = selectionRadius;
        this.pathingRadius = pathingRadius;
        this.gameplayRadius = gameplayRadius;
        this.criticalStrikeDamage = criticalStrikeDamage;
        this.criticalStrikeDamageModifier = criticalStrikeDamageModifier;
        this.attackSpeed = attackSpeed;
        this.attackSpeedRatio = attackSpeedRatio;
        this.attackCastTime = attackCastTime;
        this.attackTotalTime = attackTotalTime;
        this.attackDelayOffset = attackDelayOffset;
        this.attackRange = attackRange;
        this.aramDamageTaken = aramDamageTaken;
        this.aramDamageDealt = aramDamageDealt;
        this.aramHealing = aramHealing;
        this.aramShielding = aramShielding;
        this.urfDamageTaken = urfDamageTaken;
        this.urfDamageDealt = urfDamageDealt;
        this.urfHealing = urfHealing;
        this.urfShielding = urfShielding;
    }

    public ChampStat health { get; set; }
    public ChampStat healthRegen { get; set; }
    public ChampStat mana { get; set; }
    public ChampStat manaRegen { get; set; }
    public ChampStat armor { get; set; }
    public ChampStat magicResistance { get; set; }
    public ChampStat attackDamage { get; set; }
    public ChampStat movespeed { get; set; }
    public ChampStat acquisitionRadius { get; set; }
    public ChampStat selectionRadius { get; set; }
    public ChampStat pathingRadius { get; set; }
    public ChampStat gameplayRadius { get; set; }
    public ChampStat criticalStrikeDamage { get; set; }
    public ChampStat criticalStrikeDamageModifier { get; set; }
    public ChampStat attackSpeed { get; set; }
    public ChampStat attackSpeedRatio { get; set; }
    public ChampStat attackCastTime { get; set; }
    public ChampStat attackTotalTime { get; set; }
    public ChampStat attackDelayOffset { get; set; }
    public ChampStat attackRange { get; set; }
    public ChampStat aramDamageTaken { get; set; }
    public ChampStat aramDamageDealt { get; set; }
    public ChampStat aramHealing { get; set; }
    public ChampStat aramShielding { get; set; }
    public ChampStat urfDamageTaken { get; set; }
    public ChampStat urfDamageDealt { get; set; }
    public ChampStat urfHealing { get; set; }
    public ChampStat urfShielding { get; set; }
}
