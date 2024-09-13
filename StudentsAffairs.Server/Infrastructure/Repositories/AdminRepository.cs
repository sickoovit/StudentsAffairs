namespace StudentsAffairs.Server.Infrastructure.Repositories;

public class AdminRepository : Repository<Student, AppDbContext>, IAdminRepository
{
    public AdminRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<IEnumerable<Admin>> GetAllAdminsAsync()
    {
        return await _context.Admins.ToListAsync();
    }

    public async Task<Admin?> GetAdminByIdAsync(Guid adminId)
    {
        return await _context.Admins.FindAsync(adminId);
    }

    public async Task AddAdminAsync(Admin admin)
    {
        await _context.Admins.AddAsync(admin);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAdminAsync(Admin admin)
    {
        _context.Admins.Update(admin);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAdminAsync(Guid adminId)
    {
        var admin = await _context.Admins.FindAsync(adminId);
        if (admin != null)
        {
            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
        }
    }
}
