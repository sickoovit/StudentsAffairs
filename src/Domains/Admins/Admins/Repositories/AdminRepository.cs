namespace Admins.Repositories;

public class AdminRepository<T> : Repository<Admin>, IAdminRepository
    where T : DbContext
{
    public AdminRepository(T context) : base(context)
    {
    }

    public async Task<IEnumerable<Admin>> GetAllAdminsAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<Admin?> GetAdminByIdAsync(Guid adminId)
    {
        return await _dbSet.FindAsync(adminId);
    }

    public async Task AddAdminAsync(Admin admin)
    {
        await _dbSet.AddAsync(admin);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAdminAsync(Admin admin)
    {
        _dbSet.Update(admin);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAdminAsync(Guid adminId)
    {
        var admin = await _dbSet.FindAsync(adminId);
        if (admin != null)
        {
            _dbSet.Remove(admin);
            await _dbContext.SaveChangesAsync();
        }
    }
}
