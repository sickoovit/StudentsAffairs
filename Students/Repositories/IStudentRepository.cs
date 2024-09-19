

namespace StudentsAffairs.Server.Repositories;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllStudentsAsync();
    Task<Student?> GetStudentByIdAsync(Guid studentId);
    Task AddStudentAsync(Student student);
    Task UpdateStudentAsync(Student student);
    Task DeleteStudentAsync(Guid studentId);
    Task<IEnumerable<Student>> GetStudentsByCourseAsync(Guid courseId);
}
