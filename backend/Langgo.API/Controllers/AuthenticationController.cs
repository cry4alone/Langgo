using Langgo.Application.Services;
using Langgo.Contracts.Authentification;
using Microsoft.AspNetCore.Mvc;
using ErrorOr;

namespace Langgo.API.Controllers;


[Route("api/[controller]")]
public class AuthenticationController : ApiController
{
    private readonly IAuthenticationService _authenticationService;

    // Сделал конструктор публичным, чтобы ASP.NET Core DI мог его создать
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        ErrorOr<AuthenticationResponse> authResponse = _authenticationService.Register(
            request.Username,
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password,
            request.Language
        );
        
        return authResponse.Match(
            authResponse => Ok(MapAuthResponse(authResponse)),
            errors => Problem(errors)
        );
    }

    private static RegisterResponse MapAuthResponse(AuthenticationResponse authResponse)
    {
        return new RegisterResponse(
            authResponse.User.Id,
            authResponse.User.Username,
            authResponse.User.FirstName,
            authResponse.User.LastName,
            authResponse.User.Email,
            authResponse.Token
        );
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var registerResponse = _authenticationService.Login(
            request.Email,
            request.Password
        );

        return registerResponse.Match(
            registerResponse => Ok(MapAuthResponse(registerResponse)),
            errors => Problem(errors));
    }
    
    private static RegisterResponse MapLogResponse(AuthenticationResponse authResponse)
    {
        return new RegisterResponse(
            authResponse.User.Id,
            authResponse.User.Username,
            authResponse.User.FirstName,
            authResponse.User.LastName,
            authResponse.User.Email,
            authResponse.Token
        );
    }
}