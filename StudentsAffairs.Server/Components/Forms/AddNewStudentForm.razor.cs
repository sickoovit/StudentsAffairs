namespace StudentsAffairs.Server.Components.Forms;

public partial class AddNewStudentForm
{
    private Student newStudent = new Student();

    [Inject] private IStudentRepository StudentRepo { get; set; }

    private async Task AddStudent()
    {
        await StudentRepo.AddStudentAsync(newStudent);
        newStudent = new Student(); // Reset the form
    }
}