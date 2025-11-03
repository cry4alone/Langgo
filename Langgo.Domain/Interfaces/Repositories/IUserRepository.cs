using Langgo.Domain.Entities;

namespace Langgo.Domain.Interfaces.Repositories;

public interface IUserRepository
{
    Task<User> GetByIdAsync(Guid userId);
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(User user);
}