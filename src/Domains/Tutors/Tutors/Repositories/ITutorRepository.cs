namespace Tutors.Repositories;

public interface ITutorRepository : IRepository<Tutor>
{
    Task<IEnumerable<Tutor>> GetTutorsByCourseAsync(Guid courseId);
}
