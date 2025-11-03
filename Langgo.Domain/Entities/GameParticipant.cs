namespace Langgo.Domain.Entities;

public class GameParticipant
{
    public Guid Id { get; set; }
    
    public Guid UserId { get; set; }
    public Guid GameSessionId { get; set; }
    
    public User User { get; set; }
    public GameSession GameSession { get; set; }
    
    public int Score { get; set; }
    public int LivesRemaining { get; set; }
    public int CorrectAnswers { get; set; }
    public int IncorrectAnswers { get; set; }
}