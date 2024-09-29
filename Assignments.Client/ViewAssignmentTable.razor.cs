namespace StudentsAffairs.Server.Components.Tables;

public partial class ViewAssignmentTable
{
    [Parameter]
    public IEnumerable<Assignment>? Assignments { get; set; } 
}