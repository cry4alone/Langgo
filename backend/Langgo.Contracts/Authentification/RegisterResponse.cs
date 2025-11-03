namespace Langgo.Contracts.Authentification;

public record RegisterResponse(    
    Guid Id,
    string Username,
    string FirstName,
    string LastName,
    string Email,
    string Token);