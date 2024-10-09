namespace Students.Repositories;

public class StudentRepository : Repository<Student>, IStudentRepository
{
	public StudentRepository(AppDbContext context) : base(context)
	{
	}
	public async Task<IEnumerable<Student>> GetStudentsByCourseAsync(Guid courseId)
    {
        throw new NotImplementedException();
    }
}
