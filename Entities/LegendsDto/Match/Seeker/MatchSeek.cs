using System.Diagnostics.CodeAnalysis;

using MobaGains.Entities.LegendsDto.Enums;

namespace MobaGains.Entities.LegendsDto.Match.Seeker;

public class MatchSeek
{
    [SetsRequiredMembers]
    public MatchSeek(Guid matchGuid, long gameCreation, GameMode gameMode, List<string>? participants, List<string>? participantsTagLine)
    {
        this.matchGuid = matchGuid;
        this.gameCreation = gameCreation;
        this.gameMode = gameMode;
        this.participants = participants;
        this.participantsTagLine = participantsTagLine;
    }

    public required Guid matchGuid { get; set; } //Primary Key
    public required long gameCreation { get; set; }
    public required GameMode gameMode { get; set; }
    public required List<string>? participants { get; set; } //10 Text Fields within MatchSeek_Participants Table
    public required List<string>? participantsTagLine { get; set; } //10 Text Fields within MatchSeek_Participants Table
}
