namespace StudentsAffairs.Server.Domain.Interfaces;

public interface IUserRepository : IRepository<User>
{
    Task<IEnumerable<User>> GetUsersByRoleAsync(string role);
    Task<User> GetUserByName(string name);
    Task<User> GetUserByEmail(string email);
    Task<User> GetUserByIsActive(bool isActive);
}