﻿using MobaGains.Rigging.SolidEnums;

namespace MobaGains.Entities.Metadata.Champion;

public class StatSubDetail
{
    public StatSubDetail(int championId, KeyActivationIndexer index, int patchIndexer, int priority, string description, 
                            float? value, string? math) 
    {
        this.championId = championId;
        this.index = index;
        this.priority = priority;
        this.patchIndexer = patchIndexer;
        this.description = description;
        this.value = value;
        this.math = math;
    }

    public int championId { get; set; } //Primary Key
    public KeyActivationIndexer index { get; set; } //Primary Key
    public int priority { get; set; } //Primary Key
    public int patchIndexer { get; set; }
    public string? description { get; set; }
    public float? value { get; set; }
    public string? math { get; set; }
}
