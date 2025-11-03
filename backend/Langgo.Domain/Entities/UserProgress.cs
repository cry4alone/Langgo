namespace Langgo.Domain.Entities;

public class UserProgress
{
    public Guid Id { get; set; }
    
    public int GamesPlayed { get; set; }
    
    public ICollection<GameSession> GameSessions { get; set; } = new List<GameSession>();
}