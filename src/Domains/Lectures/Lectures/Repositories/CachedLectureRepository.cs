namespace Lectures.Repositories;

public class CachedLectureRepository : CachedRepository<Lecture>, ILectureRepository
{
    public CachedLectureRepository(IRepository<Lecture> innerRepository, ICacheService cacheService) : base(innerRepository, cacheService)
    {
    }

    public Task<IEnumerable<Lecture>> GetLecturesByCourseId(Guid courseId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Lecture>> GetLecturesByScheduledDate(DateTime scheduledDate)
    {
        throw new NotImplementedException();
    }
}
