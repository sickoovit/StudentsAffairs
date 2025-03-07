namespace Students.Repositories;

public class CachedStudentRepository : CachedRepository<Student>, IStudentRepository
{
    public CachedStudentRepository(IRepository<Student> innerRepository, ICacheService cacheService) : base(innerRepository, cacheService)
    {
    }

    public Task<IEnumerable<Student>> GetStudentsByCourseAsync(Guid courseId)
    {
        throw new NotImplementedException();
    }
}
