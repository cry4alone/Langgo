namespace Langgo.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string Email { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public int Rating { get; set; }
    
    public string Language { get; set; }
    
    public ICollection<GameParticipant> Participants { get; set; } = new List<GameParticipant>();
}