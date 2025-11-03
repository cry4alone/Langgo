using Langgo.Domain.Enums;

namespace Langgo.Domain.Entities;

public class GameSession
{

    public Guid Id { get; set; }

    public GameType Type { get; set; }

    public GameMode Mode { get; set; }
    
    public GameSessionStatus Status { get; set; }

    public WordDictionary WordsDictionary { get; set; }
    
    public ICollection<GameParticipant> Participants { get; set; } = new List<GameParticipant>();

    public void AddParticipant(GameParticipant participant)
    {
        
    }
}
