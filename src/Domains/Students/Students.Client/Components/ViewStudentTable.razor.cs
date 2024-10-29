using Students.Client.Managers;

namespace Students.Client.Components;

public partial class ViewStudentTable
{
	[Inject]
	private StudentsManager _studentsManager { get; set; }
	private IEnumerable<Student> StudentsList = [];

	protected async override Task OnInitializedAsync()
	{
		StudentsList = await _studentsManager.GetStudents();
		await base.OnInitializedAsync();
	}
}