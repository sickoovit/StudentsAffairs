namespace Tutors.Repositories;

public class CachedTutorRepository : CachedRepository<Tutor>, ITutorRepository
{
    public CachedTutorRepository(IRepository<Tutor> innerRepository, ICacheService cacheService) : base(innerRepository, cacheService)
    {
    }

    public Task<IEnumerable<Tutor>> GetTutorsByCourseAsync(Guid courseId)
    {
        throw new NotImplementedException();
    }
}
