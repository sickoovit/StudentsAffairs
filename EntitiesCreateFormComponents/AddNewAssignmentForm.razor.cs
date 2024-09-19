


namespace StudentsAffairs.Server.Components.Forms;

public partial class AddNewAssignmentForm
{
    private Assignment newAssignment = new Assignment
    {
        DueDate = DateTime.Now,
        CreatedAt = DateTime.Now
    };

    [Parameter]
    public IEnumerable<Course> Courses { get; set; }


    [Inject] private IAssignmentRepository AssignmentRepo { get; set; }

    private async Task AddAssignment()
    {
        await AssignmentRepo.AddAsync(newAssignment);
        newAssignment = new Assignment(); // Reset the form
    }
}