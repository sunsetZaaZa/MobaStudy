using MobaGains.Rigging.Utilities;

namespace MobaGains.Rigging.SolidEnums;


//TODO: Resource (Character Resource & Stat & Passive Resource), Math Formula, Full text description, Patch Version, Champion ID, Key Activation

public class AbilitySubDetail
{
    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer keyActivation { get; set; } //Primary Key
    public int patchVersion { get; set; } //Primary key
    public CharacterResource? resourceType { get; set; }
    public ChampStatType? statType { get; set; }
    public float perStatType { get; set; }
    public bool perIsPercentage { get; set; }
    public string math { get; set; }
    public CharacterResource ofResource { get; set; }
    public string description { get; set; }
}

public class AbilityUnit : StaticEnumeration
{
    private AbilityUnit(int index, string name) : base(index, name) { }

    public static readonly AbilityUnit NONE = new AbilityUnit(1, "");
    public static readonly AbilityUnit FLAT = new AbilityUnit(2, "Flat");
    public static readonly AbilityUnit PERCENT_AP = new AbilityUnit(2, "Percent AP");
    public static readonly AbilityUnit PERCENT_BONUS_AD = new AbilityUnit(3, "Percent bonus AD");
    public static readonly AbilityUnit PERCENT_AD = new AbilityUnit(4, "Percent AD");
    public static readonly AbilityUnit PERCENT = new AbilityUnit(5, "Percent");
    public static readonly AbilityUnit BASED_ON_LEVEL = new AbilityUnit(6, "Based on Level");
    public static readonly AbilityUnit PERCENT_PER_100AP = new AbilityUnit(7, "Percent per 100 AP");
    public static readonly AbilityUnit ONE_PLUS_PER100_BONUS_ATTACK_SPEED = new AbilityUnit(8, "1 + 0.3 per 100% Bonus Attack Speed");
    public static readonly AbilityUnit ONE_PLUS_FIVEO_TWOO_PER_100PER_CRIT_STRIKE_CHANCE = new AbilityUnit(9, "1 + (0.5 + 0.3) per 100% Critical Strike Chance");
    public static readonly AbilityUnit PERCENT_PLUS_TWOFIVEO_PER_100AP_TARGET_MAX_HEALTH = new AbilityUnit(10, "Percent (+ 0.25% per 100 AP) of Target's Maximum Health");
    public static readonly AbilityUnit PER_BONUS_MAGIC_RESIT = new AbilityUnit(11, "Percent Bonus Magic Resistance");
    public static readonly AbilityUnit UNITS = new AbilityUnit(12, "Units"); //TODO: Look into this more
    public static readonly AbilityUnit MOONLIGHT = new AbilityUnit(13, "Moonlight");
    public static readonly AbilityUnit STARDUST_BOOST = new AbilityUnit(14, "+ (3.1% Stardust) % of Target's Maximum Health");
    public static readonly AbilityUnit SOLDIERS = new AbilityUnit(15, "Soldiers"); //TODO: Look into this more
    public static readonly AbilityUnit PERCENT_TARGET_MISSING_HEALTH = new AbilityUnit(16, "Percent of Target's Missing Health");
    public static readonly AbilityUnit PERCENT_MAXIMUM_MANA = new AbilityUnit(17, "Percent Maximum Mana");
    public static readonly AbilityUnit PERCENT_BRAUM_MAX_HEALTH = new AbilityUnit(18, "Percent of Braum's Maximum Health");
    public static readonly AbilityUnit PERCENT_BONUS_ARMOR = new AbilityUnit(19, "Percent Bonus Armor");
    public static readonly AbilityUnit BRIAR_SNEAK_ATTACK = new AbilityUnit(20, "% (+2.5% per 100 Bonus AD) of the Target's Missing Health");
    public static readonly AbilityUnit PERCENT_TARGET_MAX_HEALTH = new AbilityUnit(21, "Percent of Target's Maximum Health");
    public static readonly AbilityUnit COHGATH_VORPAL_SPIKES_AP_DAMAGE = new AbilityUnit(22, "% (+ 0.5% per Feast stack) of Target's Maximum Health");
    public static readonly AbilityUnit COHGATH_VORPAL_SPIKES_TOTAL_AP_DAMAGE = new AbilityUnit(22, "% (+ 1.5% per Feast stack) of Target's Maximum Health");
    public static readonly AbilityUnit PERCENT_BONUS_HEALTH = new AbilityUnit(23, "Percent Bonus Health");
    public static readonly AbilityUnit EVELYNN_WHIPLASH = new AbilityUnit(24, "% (+ 1.5% per 100 AP) of Target's Maximum Health");
    public static readonly AbilityUnit EVELYNN_EMPOWERED_WHIPLASH = new AbilityUnit(25, "% (+2.5% per 100 Ability Power) of Target's Maximum Health");
    public static readonly AbilityUnit PERCENT_TARGET_CURRENT_HEALTH = new AbilityUnit(26, "Percent of Target's Current Health");
    public static readonly AbilityUnit PERCENT_100_BONUS_MAGIC_RESIST = new AbilityUnit(27, "Percent per 100 Bonus Magic Resistance");
    public static readonly AbilityUnit PERCENT_MISSING_HEALTH = new AbilityUnit(28, "Percent Missing Health");
    public static readonly AbilityUnit GANGPLANK_POWDER_KEG = new AbilityUnit(29, "% (+ 0% - 25%) Based on Critical Strike Chance");
    public static readonly AbilityUnit GWEN_FINAL_SNIP_SNIP = new AbilityUnit(30, "% (+ 0.72% per 100 AP) of the Target's Maximum Health");
    public static readonly AbilityUnit GWIN_MIN_CENTER_DAMAGE_SNIP_SNIP = new AbilityUnit(32, "% (+ 1.44% per 100 AP) of the Target's Maximum Health");
    public static readonly AbilityUnit GWIN_MAX_CENTER_DAMAGE_SNIP_SNIP = new AbilityUnit(33, "% (+ 4.32% per 100 AP) of the Target's Maximum Health");

    public static readonly List<AbilityUnit> byIndex = 
        new List<AbilityUnit>() { NONE, FLAT, PERCENT_AP, PERCENT_BONUS_AD, PERCENT_AD, PERCENT };

    public static readonly int Count = byIndex.Count();
}

public enum AbilityUnitIndexer
{
    NONE = 0,
    FLAT = 1,
    PERCENT_AP = 2,
    PERCENT_BONUS_AD = 3,
    PERCENT_AD = 4,
    PERCENT = 5
}