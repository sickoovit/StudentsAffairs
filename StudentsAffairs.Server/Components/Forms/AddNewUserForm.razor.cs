


namespace StudentsAffairs.Server.Components.Forms;

public partial class AddNewUserForm
{
    [Inject] private IStudentRepository? StudentRepo { get; set; }
    [Inject] private ITutorRepository? TutorRepo { get; set; }
    [Inject] private IAdminRepository? AdminRepo { get; set; }

    private string selectedRole;
    private User user = new();
    private Student newStudent = new();
    private Tutor newTutor = new();
    private Admin newAdmin = new();

    private void RoleChanged(ChangeEventArgs e)
    {

        selectedRole = e.Value?.ToString();
        user = selectedRole switch
        {
            "Student" => newStudent,
            "Tutor" => newTutor,
            "Admin" => newAdmin,
            _ => null
        };
    }

    private async Task HandleValidSubmit()
    {
        // Save logic based on selected role
        if (user is Student)
        {
            await StudentRepo.AddStudentAsync(newStudent);
            newStudent = new Student();
        }
        else if (user is Tutor)
        {
            await TutorRepo.AddTutorAsync(newTutor);
            newTutor = new Tutor();
        }
        else if (user is Admin)
        {
            await AdminRepo.AddAdminAsync(newAdmin);
            newAdmin = new Admin();
        }
    }
}