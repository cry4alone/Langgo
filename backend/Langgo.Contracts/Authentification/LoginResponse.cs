namespace Langgo.Contracts.Authentification;

public record LoginResponse(
    Guid Id,
    string Username,
    string FirstName,
    string LastName,
    string Email,
    string Token);