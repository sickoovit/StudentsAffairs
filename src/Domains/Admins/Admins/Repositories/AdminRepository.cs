namespace Admins.Repositories;

public class AdminRepository : Repository<Admin>, IAdminRepository
{
    public AdminRepository(AppDbContext context) : base(context)
    {
    }
}
