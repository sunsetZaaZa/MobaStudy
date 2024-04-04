using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampionAbility
{
    public ChampionAbility(int championId, KeyActivationIndexer activateKey, int patchVersion, string name, List<Leveling>? cost, List<Leveling>? cooldown,
                            bool? affectedByCooldownReduction, List<AbilityTargetingIndexer> targeting, List<AbilityAffectIndexer> affects, SpellShieldableIndexer spellshieldable,
                            CharacterResourceIndexer primaryResource, DamageTypeIndexer damageType, List<AbilityEffectsIndexer> abilityEffects, ProjectileTypeIndexer projectile,
                            string? onHitEffects, int occurrence, string notes, List<StatSubDetail>? missileSpeed, List<float>? rechargeRate, float? collisionRadius, 
                            List<StatSubDetail>? tetherRadius, List<StatSubDetail>? onTargetCdStatic, List<StatSubDetail>? innerRadius, List<StatSubDetail>? speed, List<StatSubDetail>? width, 
                            List<StatSubDetail>? angle, List<StatSubDetail>? castTime, List<StatSubDetail>? effectRadius, List<StatSubDetail>? targetRange)
    {
        this.championId = championId;
        this.activateKey = activateKey;
        this.patchVersion = patchVersion;
        this.name = name;
        this.cost = cost;
        this.cooldown = cooldown;
        this.affectedByCooldownReduction = affectedByCooldownReduction;
        this.targeting = targeting;
        this.affects = affects;
        this.spellshieldable = spellshieldable;
        this.primaryResource = primaryResource;
        this.damageType = damageType;
        this.abilityEffects = abilityEffects;
        this.projectile = projectile;
        this.onHitEffects = onHitEffects;
        this.occurrence = occurrence;
        this.notes = notes;
        this.missileSpeed = missileSpeed;
        this.rechargeRate = rechargeRate;
        this.collisionRadius = collisionRadius;
        this.tetherRadius = tetherRadius;
        this.onTargetCdStatic = onTargetCdStatic;
        this.innerRadius = innerRadius;
        this.speed = speed;
        this.width = width;
        this.angle = angle;
        this.castTime = castTime;
        this.effectRadius = effectRadius;
        this.targetRange = targetRange;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer activateKey { get; set; } //Primary Key
    public int patchVersion { get; set; }
    public string name { get; set; }
    public List<ChampionAbilityEffect> effects { get; set; }
    public List<Leveling>? cost { get; set; }
    public List<Leveling>? cooldown { get; set; }
    public bool? affectedByCooldownReduction { get; set; }
    public List<AbilityTargetingIndexer> targeting { get; set; }
    public List<AbilityAffectIndexer> affects { get; set; }
    public SpellShieldableIndexer spellshieldable { get; set; }
    public CharacterResourceIndexer primaryResource { get; set; }
    public DamageTypeIndexer damageType { get; set; }
    public List<AbilityEffectsIndexer> abilityEffects { get; set; }
    public ProjectileTypeIndexer projectile { get; set; }
    public string? onHitEffects { get; set; }
    public int occurrence { get; set; }
    public string notes { get; set; }
    public List<StatSubDetail>? missileSpeed { get; set; }
    public List<float>? rechargeRate { get; set; }
    public float? collisionRadius { get; set; }
    public List<StatSubDetail>? tetherRadius { get; set; }
    public List<StatSubDetail>? onTargetCdStatic { get; set; }
    public List<StatSubDetail>? innerRadius { get; set; }
    public List<StatSubDetail>? speed { get; set; }
    public List<StatSubDetail>? width { get; set; }
    public List<StatSubDetail>? angle { get; set; }
    public List<StatSubDetail>? castTime { get; set; }
    public List<StatSubDetail>? effectRadius { get; set; }
    public List<StatSubDetail>? targetRange { get; set; }
}
