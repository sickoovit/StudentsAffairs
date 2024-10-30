using Assignments.Client.Managers;

namespace Assignments.Client.Components;

public partial class ViewAssignmentTable
{
	[Inject]
	private IAssignmentsManager AssignmentsManager { get; set; }
	private IEnumerable<Assignment> AssignmentsList = [];

	protected async override Task OnInitializedAsync()
	{
		AssignmentsList = await AssignmentsManager.GetAssignments();
		await base.OnInitializedAsync();
	}
}