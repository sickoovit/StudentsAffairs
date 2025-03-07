namespace Admins.Repositories;

public class CachedAdminRepository : CachedRepository<Admin>, IAdminRepository
{
    public CachedAdminRepository(IRepository<Admin> innerRepository, ICacheService cacheService) : base(innerRepository, cacheService)
    {
    }
}
