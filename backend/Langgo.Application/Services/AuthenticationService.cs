using Langgo.Application.Common.Interfaces.Authentication;
using Langgo.Application.Common.Interfaces.Persistence;
using Langgo.Domain.Entities;

namespace Langgo.Application.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }
    public AuthenticationResponse Login(string email, string password)
    {
        var existingUser = _userRepository.GetUserByEmail(email);
        if (existingUser == null) 
            throw new Exception("User not found");
        
        if(existingUser.Password != password)
            throw new Exception("Wrong password");
        
        var token = _jwtTokenGenerator.GenerateToken(existingUser);
        
        return new AuthenticationResponse(existingUser, token);
    }

    public AuthenticationResponse Register(string username, string firstName, string lastName, string email, string password, string language)
    {
        var existingUser = _userRepository.GetUserByEmail(email);
        if (existingUser != null) throw new Exception("User with this email already exists");

        var user = new User
        {
            Username = username,
            Email = email,
            FirstName = firstName,
            LastName = lastName,
            Password = password,
            Language = language,
            Rating = 0
        };
        
        _userRepository.Add(user);
        
        var token = _jwtTokenGenerator.GenerateToken(user);
            
        return new AuthenticationResponse(user, token);
    }
}