
namespace Students.Client.Managers
{
	public interface IStudentsManager
	{
		Task<IEnumerable<Student>> GetStudents();
	}
}