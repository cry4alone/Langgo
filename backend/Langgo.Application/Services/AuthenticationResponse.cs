using Langgo.Domain.Entities;

namespace Langgo.Application.Services;

public record AuthenticationResponse(
        User User,
        string Token);