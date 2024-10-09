namespace Shared.Repositories;

public class UserRepository : Repository<User>, IUserRepository
{
	public UserRepository(AppDbContext context) : base(context)
    {
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