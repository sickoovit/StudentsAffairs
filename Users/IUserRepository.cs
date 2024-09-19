

namespace StudentsAffairs.Server.Repositories;

public interface IUserRepository : IRepository<User>
{
    Task<IEnumerable<User>> GetUsersByRoleAsync(string role);
    User? GetUserByUsername(string username);
    Task<User?> GetUserByNameAsync(string name);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User?> GetUserByIsActiveAsync(bool isActive);
}