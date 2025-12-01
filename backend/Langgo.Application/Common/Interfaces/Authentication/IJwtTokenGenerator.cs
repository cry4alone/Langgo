using Langgo.Domain.Entities;

namespace Langgo.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}