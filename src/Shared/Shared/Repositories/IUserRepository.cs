namespace Shared.Repositories;

public interface IUserRepository : IRepository<User>
{
    User? GetUserByUsername(string username);
    Task<User?> GetUserByNameAsync(string name);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User?> GetUserByIsActiveAsync(bool isActive);
}