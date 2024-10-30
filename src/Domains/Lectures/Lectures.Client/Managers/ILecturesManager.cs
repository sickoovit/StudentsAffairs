
namespace Lectures.Client.Managers
{
	public interface ILecturesManager
	{
		Task<IEnumerable<Course>> GetCourses();
		Task<IEnumerable<Lecture>> GetLectures();
	}
}