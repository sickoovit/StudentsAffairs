namespace Assignments.Client.Components;

public partial class ViewAssignmentTable
{
    [Parameter]
    public IEnumerable<Assignment>? AssignmentsList{ get; set; }
}