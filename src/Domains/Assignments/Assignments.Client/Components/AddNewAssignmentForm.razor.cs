using Assignments.Client.Managers;

namespace Assignments.Client.Components;

public partial class AddNewAssignmentForm
{
    private Assignment newAssignment = new Assignment
    {
        DueDate = DateTime.Now,
        CreatedAt = DateTime.Now
    };

	[Inject]
	private IAssignmentsManager AssignmentsManager { get; set; }
	private IEnumerable<Course> CoursesList = [];

	protected async override Task OnInitializedAsync()
	{
		CoursesList = await AssignmentsManager.GetCourses();
		await base.OnInitializedAsync();
	}


	[Inject] private IAssignmentRepository AssignmentRepo { get; set; }

    private async Task AddAssignment()
    {
        await AssignmentRepo.AddAsync(newAssignment);
        newAssignment = new Assignment(); // Reset the form
    }
}