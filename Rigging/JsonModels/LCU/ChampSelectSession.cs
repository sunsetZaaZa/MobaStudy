namespace MobaGains.Rigging.JsonModels.LCU;

public class TeamBans
{
    public TeamBans(List<int> myTeamBans, int numBans, List<int> theirTeamBans>)
    {
        this.myTeamBans = myTeamBans;
        this.numBans = numBans;
        this.theirTeamBans = theirTeamBans;
    }

    public List<int> myTeamBans { get; set; }
    public int numBans { get; set; }
    public List<int> theirTeamBans { get; set; }
}

public class ChatInfo
{
    public ChatInfo(string chatRoomName, string chatRoomPassword)
    {
        this.chatRoomName = chatRoomName;
        this.chatRoomPassword = chatRoomPassword;
    }

    public string chatRoomName { get; set; }
    public string chatRoomPassword { get; set; }
}

public class FeatureState 
{
    public FeatureState(int additionalRerolls, List<int> unlockedSkinIds)
    {
        this.additionalRerolls = additionalRerolls;
        this.unlockedSkinIds = unlockedSkinIds;
    }

    public int additionalRerolls { get; set; }
    public List<int> unlockedSkinIds { get; set; }
}

public class Player
{
    public Player(string assignedPosition, int cellId, int championId, int championPickIntent, string entitledFeatureType, int selectedSkinId, int spell1Id, int spell2Id, int summonerId, int team, int wardSkinId)
    {
        this.assignedPosition = assignedPosition;
        this.cellId = cellId;
        this.championId = championId;
        this.championPickIntent = championPickIntent;
        this.entitledFeatureType = entitledFeatureType;
        this.selectedSkinId = selectedSkinId;
        this.spell1Id = spell1Id;
        this.spell2Id = spell2Id;
        this.summonerId = summonerId;
        this.team = team;
        this.wardSkinId = wardSkinId;
    }

    public string assignedPosition { get; set; }
    public int cellId { get; set; }
    public int championId { get; set; }
    public int championPickIntent { get; set; }
    public string entitledFeatureType { get; set; }
    public int selectedSkinId { get; set; }
    public int spell1Id { get; set; }
    public int spell2Id { get; set; }
    public int summonerId { get; set; }
    public int team { get; set; }
    public int wardSkinId { get; set; }
}

public class GameTimer
{
    public GameTimer(int adjustedTimeLeftInPhase, int internalNowInEpochMs, bool isInfinite, string phase, string totalTimeInPhase)
    {
        this.adjustedTimeLeftInPhase = adjustedTimeLeftInPhase;
        this.internalNowInEpochMs = internalNowInEpochMs;
        this.isInfinite = isInfinite;
        this.phase = phase;
        this.totalTimeInPhase = totalTimeInPhase;
    }

    public int adjustedTimeLeftInPhase { get; set; }
    public int internalNowInEpochMs { get; set; }
    public bool isInfinite { get; set; }
    public string phase { get; set; }
    public string totalTimeInPhase { get; set; }
}

public class TradeDetail
{
    public TradeDetail(int cellId, int id, string state)
    {
        this.cellId = cellId;
        this.id = id;
        this.state = state;
    }

    public int cellId { get; set; }
    public int id { get; set; }
    public string state { get; set; }
}

public class ChampSelectSession
{
    public ChampSelectSession(bool allowBattleBoost, bool allowDuplicatePicks, bool allowLockedEvents, bool allowSkinSelection, TeamBans bans, List<int> benchChampionIds, bool benchEnabled, int boostableSkinCount,
                                ChatInfo chatDetails, int counter, FeatureState entitledFeatureState, int gameId, bool hasSimultaneousBans, bool hasSimultaneousPicks, bool isCustomGame, bool isSpectating,
                                int localPlayerCellId, int lockedEventIndex, List<Player> myTeam, int recoveryCounter, int rerollsRemaining, bool skipChampionSelect, List<Player> theirTeam, GameTimer timer,
                                List<TradeDetail> trades)
    {
        this.allowBattleBoost = allowBattleBoost;
        this.allowDuplicatePicks = allowDuplicatePicks;
        this.allowLockedEvents = allowLockedEvents;
        this.allowSkinSelection = allowSkinSelection;
        this.bans = bans;
        this.benchChampionIds = benchChampionIds;
        this.benchEnabled = benchEnabled;
        this.boostableSkinCount = boostableSkinCount;
        this.chatDetails = chatDetails;
        this.counter = counter;
        this.entitledFeatureState = entitledFeatureState;
        this.gameId = gameId;
        this.hasSimultaneousBans = hasSimultaneousBans;
        this.hasSimultaneousPicks = hasSimultaneousPicks;
        this.isCustomGame = isCustomGame;
        this.isSpectating = isSpectating;
        this.localPlayerCellId = localPlayerCellId;
        this.lockedEventIndex = lockedEventIndex;
        this.myTeam = myTeam;
        this.recoveryCounter = recoveryCounter;
        this.rerollsRemaining = rerollsRemaining;
        this.skipChampionSelect = skipChampionSelect;
        this.theirTeam = theirTeam;
        this.timer = timer;
        this.trades = trades;
    }
    //public List<string> actions { get; set; }
    public bool allowBattleBoost { get; set; }
    public bool allowDuplicatePicks { get; set; }
    public bool allowLockedEvents { get; set; }
    public bool allowSkinSelection { get; set; }
    public TeamBans bans { get; set; }
    public List<int> benchChampionIds { get; set; }
    public bool benchEnabled { get; set; }
    public int boostableSkinCount { get; set; }
    public ChatInfo chatDetails { get; set; }
    public int counter { get; set; }
    public FeatureState entitledFeatureState { get; set; }
    public int gameId { get; set; }
    public bool hasSimultaneousBans { get; set; }
    public bool hasSimultaneousPicks { get; set; }
    public bool isCustomGame { get; set; }
    public bool isSpectating { get; set; }
    public int localPlayerCellId { get; set; }
    public int lockedEventIndex { get; set; }
    public List<Player> myTeam { get; set; }
    public int recoveryCounter { get; set; }
    public int rerollsRemaining { get; set; }
    public bool skipChampionSelect { get; set; }
    public List<Player> theirTeam { get; set; }
    public GameTimer timer { get; set; }
    public List<TradeDetail> trades { get; set; }
}
