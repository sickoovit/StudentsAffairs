using Students.Entities;

namespace Students.Repositories;

public interface IStudentRepository : IRepository<Student>
{
    Task<IEnumerable<Student>> GetStudentsByCourseAsync(Guid courseId);
}
