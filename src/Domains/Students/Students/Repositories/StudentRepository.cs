using Students.Entities;

namespace Students.Repositories;

public class StudentRepository<T> : Repository<Student>, IStudentRepository
    where T : DbContext
{
    public StudentRepository(T context) : base(context)
    {
    }

    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<Student?> GetStudentByIdAsync(Guid studentId)
    {
        return await _dbSet.FindAsync(studentId);
    }

    public async Task AddStudentAsync(Student student)
    {
        await _dbSet.AddAsync(student);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateStudentAsync(Student student)
    {
        _dbSet.Update(student);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteStudentAsync(Guid studentId)
    {
        var student = await _dbSet.FindAsync(studentId);
        if (student != null)
        {
            _dbSet.Remove(student);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Student>> GetStudentsByCourseAsync(Guid courseId)
    {
        throw new NotImplementedException();
    }
}
