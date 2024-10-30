using Students.Client.Managers;

namespace Students.Client.Components;

public partial class ViewStudentTable
{
	[Inject]
	private IStudentsManager StudentsManager { get; set; }
	private IEnumerable<Student> StudentsList = [];

	protected async override Task OnInitializedAsync()
	{
		StudentsList = await StudentsManager.GetStudents();
		await base.OnInitializedAsync();
	}
}