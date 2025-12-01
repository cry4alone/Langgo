namespace Langgo.Contracts.Authentification;

public record RegisterRequest(
    string Username,
    string LastName,
    string FirstName,
    string Email,
    string Password,
    string Language
);