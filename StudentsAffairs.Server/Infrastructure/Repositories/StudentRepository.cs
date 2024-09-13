namespace StudentsAffairs.Server.Infrastructure.Repositories;

public class StudentRepository : Repository<Student, AppDbContext>, IStudentRepository
{
    public StudentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Student>> GetAllStudentsAsync()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student?> GetStudentByIdAsync(Guid studentId)
    {
        return await _context.Students.FindAsync(studentId);
    }

    public async Task AddStudentAsync(Student student)
    {
        await _context.Students.AddAsync(student);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateStudentAsync(Student student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudentAsync(Guid studentId)
    {
        var student = await _context.Students.FindAsync(studentId);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Student>> GetStudentsByCourseAsync(Guid courseId)
    {
        return await _context.Students
            .Where(s => s.Courses.Any(c => c.Id == courseId))
            .ToListAsync();
    }
}
