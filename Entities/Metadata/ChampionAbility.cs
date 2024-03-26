using MobaGains.Rigging.SolidEnums;
using System.Speech.Recognition;

namespace MobaGains.Entities.Metadata;

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
    public ChampionAbility(Guid marker, int championId, string name, List<string> description, KeyActivation activateKey, CharacterResource costType,
                            List<int> cost, List<int> cooldown, bool affectedByCooldownReduction, )
    {
        this.marker = marker;
        this.championId = championId;
        this.name = name;
        this.description = description;
        this.activateKey = activateKey;
        this.costType = costType;

    }

    public Guid marker { get; set; }
    public int championId { get; set; }
    public string name { get; set; }
    public List<string> description { get; set; }
    public KeyActivation activateKey { get; set; }
    public CharacterResource costType { get; set; }
    public List<int> cost { get; set; }
    public List<int> cooldown { get; set; }
    public bool affectedByCooldownReduction { get; set; }
    public List<AbilityTargetingIndexer> abilityTargeting { get; set; }
    public List<AbilityAffectIndexer> abilityAffects { get; set; }
    public DamageType damageType { get; set; }
    public List<AbilityEffectsIndexer> abilityEffects { get; set; }
    public bool projectile { get; set; }
    public List<OnHitEffectIndexer> onHitEffects { get; set; }
    public int occurence { get; set; }
    public string notes { get; set; }
    public float? missleSpeed { get; set; }
    public float? rechargeRate { get; set; }
    public float? collisionRadius { get; set; }
    public float? tetherRadius { get; set; }
    public float? onTargetCdStatic { get; set; }
    public float? innerRadius { get; set; }
    public List<Tuple<string, int>>? speed { get; set; }
    public List<Tuple<string, int>>? width { get; set; }
    public int? angle { get; set; }
    public List<Tuple<string, float>>? castTime { get; set; }
    public List<Tuple<string, int>> effectRadius { get; set; }
    public List<Tuple<string, int>> targetRange { get; set; }
}
