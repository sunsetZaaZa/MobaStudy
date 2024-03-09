using System.Collections;

namespace MobaGains.Rigging.JsonModels;

public class ChampionInfoDto
{
    public ChampionInfoDto(int maxNewPlayerLevel, List<int> freeChampionIdsForNewPlayers, List<int> freeChampionIds)
    {
        this.maxNewPlayerLevel = maxNewPlayerLevel;
        this.freeChampionIdsForNewPlayers = freeChampionIdsForNewPlayers;
        this.freeChampionIds = freeChampionIds;
    }

    public int maxNewPlayerLevel { get; set; }
    public List<int> freeChampionIdsForNewPlayers { get; set; }
    public List<int> freeChampionIds { get; set; }
}
