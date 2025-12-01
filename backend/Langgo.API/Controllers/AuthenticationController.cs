using Langgo.Application.Services;
using Langgo.Contracts.Authentification;
using Microsoft.AspNetCore.Mvc;

namespace Langgo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
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
        var authResponse = _authenticationService.Register(
            request.Username,
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password,
            request.Language
        );
        var response = new RegisterResponse(
            authResponse.User.Id,
            authResponse.User.Username,
            authResponse.User.FirstName,
            authResponse.User.LastName,
            authResponse.User.Email,
            authResponse.Token
        );
        
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var registerResponse = _authenticationService.Login(
            request.Email,
            request.Password
        );
        var response = new RegisterResponse(
            registerResponse.User.Id,
            registerResponse.User.Username,
            registerResponse.User.FirstName,
            registerResponse.User.LastName,
            registerResponse.User.Email,
            registerResponse.Token
        );
        
        return Ok(response);
    }
}