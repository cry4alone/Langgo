using Langgo.Domain.Entities;

namespace Langgo.Domain.Interfaces.Repositories;

public interface IGameSessionRepository
{
    Task<GameSession> CreateAsync(GameSession gameSession);
    Task<GameParticipant> AddParticipantAsync(Guid gameSessionId, Guid participantId);
    Task<GameSession> UpdateAsync(GameSession gameSession);
}