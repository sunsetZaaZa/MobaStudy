using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public struct AbilityLevels
{
    public AbilityLevels(List<Tuple<AbilityUnitIndexer, List<int>>> modifiers)
    {
        this.modifiers = modifiers;
    }

    public List<Tuple<AbilityUnitIndexer, List<int>>> modifiers { get; set; }
}

/*
 *
 */
public class AbilityEffect
{
    public AbilityEffect(Guid marker, Guid championAbility, List<string> descriptions, List<AbilityAttributeIndexer> attributes, List<AbilityLevels> innerStats)
    {
        this.marker = marker;
        this.championAbility = championAbility;
        this.descriptions = descriptions;
        this.attributes = attributes;
        this.innerStats = innerStats;
    }

    public Guid marker { get; set; }
    public Guid championAbility { get; set; }
    public List<string> descriptions { get; set; }
    public List<AbilityAttributeIndexer> attributes { get; set; }
    public List<AbilityLevels> innerStats { get; set; }
}


public class ChampionAbility
{
    public ChampionAbility(int championId, string name, List<string> description, KeyActivation activateKey, CharacterResource costType,
                            List<int> cost, List<int> cooldown, bool affectedByCooldownReduction, )
    {
        this.championId = championId;
        this.name = name;
        this.activateKey = activateKey;
        this.costType = costType;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivation activateKey { get; set; } //Primary Key
    public string name { get; set; }
    public List<Leveling>? cost { get; set; }
    public List<Leveling>? cooldown { get; set; }
    public bool? affectedByCooldownReduction { get; set; }
    public List<AbilityTargetingIndexer> targeting { get; set; }
    public List<AbilityAffectIndexer> affects { get; set; }
    public SpellShieldableIndexer spellshieldable { get; set; }
    public CharacterResourceIndexer costType { get; set; }
    public DamageTypeIndexer damageType { get; set; }
    public List<AbilityEffectsIndexer> abilityEffects { get; set; }
    public ProjectileIndexer projectile { get; set; }
    public string? onHitEffects { get; set; }
    public int occurrence { get; set; }
    public string notes { get; set; }
    public List<StatSubDetail>? missleSpeed { get; set; }
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
    public EffectRadiusIndexer effectRadiusType { get; set; }
    public List<StatSubDetail>? targetRange { get; set; }
    public TargetRangeIndexer targetRangeType { get; set; }
}
