﻿namespace MobaGains.Rigging.JsonModels.LCU;

public class ValidateRunePageRequest
{
    public ValidateRunePageRequest(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public int id { get; set; }
    public string name { get; set; }
}
