using Langgo.Application.Common.Interfaces.Authentication;

namespace Langgo.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }
    public AuthenticationResponse Login(string email, string password)
    {
    
        
        return new AuthenticationResponse(Guid.NewGuid(), "username", "FirstName", "LastName", email, "token");
    }

    public AuthenticationResponse Register(string username, string firstName, string lastName, string email, string password)
    {
        var userId = Guid.NewGuid();
        
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);
            
        return new AuthenticationResponse(userId, username, firstName, lastName, email, token);
    }
}