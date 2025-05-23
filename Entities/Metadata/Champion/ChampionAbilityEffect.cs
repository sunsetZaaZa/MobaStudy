﻿using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class ChampionAbilityEffect
{
    public ChampionAbilityEffect(int championId, KeyActivationIndexer index, int ordering, int patchIndexer, string description, List<AbilityAttribute> detail)
    {
        this.championId = championId;
        this.index = index;
        this.ordering = ordering;
        this.patchIndexer = patchIndexer;
        this.description = description;
        this.detail = detail;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer index { get; set; } //Primary Key
    public int ordering { get; set; } //Primary Key
    public int patchIndexer { get; set; }
    public string description { get; set; }
    public List<AbilityAttribute> detail { get; set; }
}
