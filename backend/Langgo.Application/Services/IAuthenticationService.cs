namespace Langgo.Application.Services;

public interface IAuthenticationService
{
    AuthenticationResponse Login(string username, string password);
    AuthenticationResponse Register(string username, string firstName, string lastName, string email, string password, string language);
}