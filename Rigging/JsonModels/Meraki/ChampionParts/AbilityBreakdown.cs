namespace MobaGains.Rigging.JsonModels.Meraki.ChampionParts;

public class AbilityBreakdown
{
    public AbilityBreakdown(string name, string icon, List<AbilityEffect> effects, SubDetails cost, Cooldown cooldown, string targeting, string affects, string spellshieldable, string? resource,
                            string? damageType, string? spellEffects, string? projectile, string? onHitEffects, string? occurrence, string? notes, string? blurb, string? missleSpeed, string? rechargeRate,
                            string? collisionRadius, string? tetherRadius, string? onTargetCdStatic, string? innerRadius, string? speed, string? width, string? angle, string castTime,
                            string effectRadius, string? targetRange)
    {
        this.name = name;
        this.icon = icon;
        this.effects = effects;
        this.cost = cost;
        this.cooldown = cooldown;
        this.targeting = targeting;
        this.affects = affects;
        this.spellshieldable = spellshieldable;
        this.resource = resource;
        this.damageType = damageType;
        this.spellEffects = spellEffects;
        this.projectile = projectile;
        this.onHitEffects = onHitEffects;
        this.occurrence = occurrence;
        this.notes = notes;
        this.blurb = blurb;
        this.missileSpeed = missileSpeed;
        this.rechargeRate = rechargeRate;
        this.collisionRadius = collisionRadius;
        this.tetherRadius = tetherRadius;
        this.ontTargetCdStatic = onTargetCdStatic;
        this.innerRadius = innerRadius;
        this.speed = speed;
        this.width = width;
        this.angle = angle;
        this.castTime = castTime;
        this.effectRadius = effectRadius;
        this.targetRange = targetRange;
    }

    public string name { get; set; }
    public string icon { get; set; }
    public List<AbilityEffect> effects { get; set; }
    public SubDetails cost { get; set; }
    public Cooldown cooldown { get; set; }
    public string targeting { get; set; }
    public string affects { get; set; }
    public string spellshieldable { get; set; }
    public string? resource { get; set; }
    public string? damageType { get; set; }
    public string? spellEffects { get; set; }
    public string? projectile { get; set; }
    public string? onHitEffects { get; set; }
    public string? occurrence { get; set; }
    public string? notes { get; set; }
    public string? blurb { get; set; }
    public string? missileSpeed { get; set; }
    public string? rechargeRate { get; set; }
    public string? collisionRadius { get; set; }
    public string? tetherRadius { get; set; }
    public string? ontTargetCdStatic { get; set; }
    public string? innerRadius { get; set; }
    public string? speed { get; set; }
    public string? width { get; set; }
    public string? angle { get; set; }
    public string castTime { get; set; }
    public string effectRadius { get; set; }
    public string? targetRange { get; set; }
}
