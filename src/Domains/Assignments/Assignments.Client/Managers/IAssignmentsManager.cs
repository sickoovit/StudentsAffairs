
namespace Assignments.Client.Managers
{
	public interface IAssignmentsManager
	{
		Task<IEnumerable<Assignment>> GetAssignments();
		Task<IEnumerable<Course>> GetCourses();
	}
}