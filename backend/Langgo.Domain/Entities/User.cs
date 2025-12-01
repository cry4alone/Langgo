namespace Langgo.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    
    public string FirstName { get; set; } = null!;
    
    public string LastName { get; set; } = null!;
    
    public int Rating { get; set; }
    
    public string Language { get; set; } = null!;
    
    public ICollection<GameParticipant> Participants { get; set; } = new List<GameParticipant>();
}