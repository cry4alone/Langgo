namespace Langgo.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResponse Login(string email, string password)
    {
        return new AuthenticationResponse(Guid.NewGuid(), "username", "FirstName", "LastName", email, "token");
    }

    public AuthenticationResponse Register(string username, string firstName, string lastName, string email, string password)
    {
        return new AuthenticationResponse(Guid.NewGuid(), username, firstName, lastName, email, "token");
    }
}