namespace MobaGains.Entities.LegendsDto.Match;

public class Info
{
    public Info(Guid matchGuid, long gameId, long gameCreation, long gameDuration, long gameEndTimestamp, string gameMode,
        string gameName, long gameStartTimestamp, string gameType, string gameVersion, int mapId, List<Participant> participants,
        string platformId, int queueId, List<Team> teams, string tournamentCode)
    {
        this.matchGuid = matchGuid;
        this.gameId = gameId;
        this.gameCreation = gameCreation;
        this.gameDuration = gameDuration;
        this.gameEndTimestamp = gameEndTimestamp;
        this.gameMode = gameMode;
        this.gameName = gameName;
        this.gameStartTimestamp = gameStartTimestamp;
        this.gameType = gameType;
        this.gameVersion = gameVersion;
        this.mapId = mapId;
        this.participants = participants;
        this.platformId = platformId;
        this.queueId = queueId;
        this.teams = teams;
        this.tournamentCode = tournamentCode;
    }

    public Guid matchGuid { get; set; } //Foreign key of Match & Primary Key for Info
    public long gameId { get; set; }
    public long gameCreation { get; set; }
    public long gameDuration { get; set; }
    public long gameEndTimestamp { get; set; }
    public string gameMode { get; set; }
    public string gameName { get; set; }
    public long gameStartTimestamp { get; set; }
    public string gameType { get; set; }
    public string gameVersion { get; set; }
    public int mapId { get; set; } 
    public List<Participant> participants { get; set; }
    public string platformId { get; set; }
    public int queueId { get; set; }
    public List<Team> teams { get; set; }
    public string tournamentCode { get; set; }
}
