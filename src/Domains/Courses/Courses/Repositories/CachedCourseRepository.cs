namespace Courses.Repositories;

public class CachedCourseRepository : CachedRepository<Course>, ICourseRepository
{
    public CachedCourseRepository(IRepository<Course> innerRepository, ICacheService cacheService) : base(innerRepository, cacheService)
    {
    }

    public Task<Course?> GetCourseByTitleAsync(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesByCategoryAsync(string category)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Course>> GetCoursesWithLecturesAsync()
    {
        throw new NotImplementedException();
    }
}
