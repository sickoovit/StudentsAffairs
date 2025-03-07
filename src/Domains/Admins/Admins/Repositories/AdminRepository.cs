namespace Admins.Repositories;

public class AdminRepository : CachedRepository<Admin>, IAdminRepository
{
    public AdminRepository(IRepository<Admin> innerRepository, ICacheService cacheService) : base(innerRepository, cacheService)
    {
    }
}
