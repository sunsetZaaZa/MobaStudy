namespace MobaGains.Rigging.JsonModels.Match;

public class InfoDto
{
    public InfoDto(long gameCreation, long gameDuration, long gameEndTimestamp, long gameId, string gameMode,
        string gameName, long gameStartTimestamp, string gameType, string gameVersion, int mapId, List<ParticipantDto> participants,
        string platformId, int queueId, List<TeamDto> teams, string tournamentCode)
    {
        this.gameCreation = gameCreation;
        this.gameDuration = gameDuration;
        this.gameEndTimestamp = gameEndTimestamp;
        this.gameId = gameId;
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

    public long gameCreation { get; set; }
    public long gameDuration { get; set; }
    public long gameEndTimestamp { get; set; }
    public long gameId { get; set; }
    public string gameMode { get; set; }
    public string gameName { get; set; }
    public long gameStartTimestamp { get; set; }
    public string gameType { get; set; }
    public string gameVersion { get; set; }
    public int mapId { get; set; }
    public List<ParticipantDto> participants { get; set; }
    public string platformId { get; set; }
    public int queueId { get; set; }
    public List<TeamDto> teams { get; set; }
    public string tournamentCode { get; set; }
}
