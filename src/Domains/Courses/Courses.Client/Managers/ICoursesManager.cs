
namespace Courses.Client.Managers
{
	public interface ICoursesManager
	{
		Task<IEnumerable<Course>> GetCourses();
	}
}