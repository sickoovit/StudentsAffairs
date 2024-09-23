namespace Shared.Repositories;

public class UserRepository<T> : Repository<User>, IUserRepository
    where T : DbContext
{
	public UserRepository(T context) : base(context)
    {
    }

    public async Task<IEnumerable<User>> GetUsersByRoleAsync(string role)
    {
        // Using LINQ to filter users by role
        return await _dbSet
            .Where(u => u.Role != null && u.Role.Equals(role, StringComparison.OrdinalIgnoreCase))
            .ToListAsync();
    }

    public User? GetUserByUsername(string username)
    {
        return _dbSet
			.FirstOrDefault(u => u.Username != null && u.Username.Equals(username));
    }

    // Get a single user by name asynchronously
    public async Task<User?> GetUserByNameAsync(string name)
    {
        return await _dbSet
			.FirstOrDefaultAsync(u => u.Name != null && u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    // Get a single user by email asynchronously
    public async Task<User?> GetUserByEmailAsync(string email)
    {
        return await _dbSet
			.FirstOrDefaultAsync(u => u.Email != null && u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }

    // Get a single user by active status asynchronously
    public async Task<User?> GetUserByIsActiveAsync(bool isActive)
    {
        return await _dbSet
			.FirstOrDefaultAsync(u => u.IsActive == isActive);
    }

}