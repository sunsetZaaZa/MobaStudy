namespace MobaGains.Rigging.JsonModels.LCU;

public class MutedPlayer
{
    public MutedPlayer(string puuid, int summonerId)
    {
        this.puuid = puuid;
        this.summonerId = summonerId;
    }

    public string puuid { get; set; }
    public int summonerId { get; set; }
}
