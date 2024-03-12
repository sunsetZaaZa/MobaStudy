namespace MobaGains.Rigging.JsonModels;

public class ChampionRotationDto
{

    public ChampionRotationDto(int maxNewPlayerLevel, List<int> freeChampionIdsForNewPlayers, List<int> freeChampionIds)
    {
        this.maxNewPlayerLevel = maxNewPlayerLevel;
        this.freeChampionIdsForNewPlayers = freeChampionIdsForNewPlayers;
        this.freeChampionIds = freeChampionIds;
    }

    int maxNewPlayerLevel { get; set; }
    List<int> freeChampionIdsForNewPlayers { get; set; }
    List<int> freeChampionIds { get; set; }
}
