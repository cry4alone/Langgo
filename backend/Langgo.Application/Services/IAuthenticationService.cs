using ErrorOr;

namespace Langgo.Application.Services;

public interface IAuthenticationService
{
    ErrorOr<AuthenticationResponse> Login(string username, string password);
    ErrorOr<AuthenticationResponse> Register(string username, string firstName, string lastName, string email, string password, string language);
}