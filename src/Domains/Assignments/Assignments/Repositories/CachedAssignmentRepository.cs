using StudentsAffairs.Redis.Services;

namespace Assignments.Repositories;

public class CachedAssignmentRepository : CachedRepository<Assignment>, IAssignmentRepository
{
    public CachedAssignmentRepository(IRepository<Assignment> innerRepository, ICacheService cacheService) : base(innerRepository, cacheService)
    {
    }

    public Task<IEnumerable<Assignment>> GetAssignmentsByCourseIdAsync(Guid courseId)
    {
        throw new NotImplementedException();
    }
}
