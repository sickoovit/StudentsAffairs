using Courses.Client.Managers;

namespace Courses.Client.Components;

public partial class ViewCourseTable
{
	[Inject]
	private ICoursesManager _coursesManager { get; set; }
	private IEnumerable<Course> CoursesList = [];

	protected async override Task OnInitializedAsync()
	{
		CoursesList = await _coursesManager.GetCourses();
		await base.OnInitializedAsync();
	}
}