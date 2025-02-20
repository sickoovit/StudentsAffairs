using Students.Client.Managers;

namespace Students.Client.Components
{
    public partial class AddNewStudentForm
    {
		[Inject]
		private IStudentsManager StudentsManager { get; set; }

		private Student newStudent = new();
		private void UpdateEmail()
		{
			newStudent.Email = newStudent.Name + "@innotech.sa.com";
			newStudent.Password = "$$123123##";
		}
		private async Task HandleValidSubmit()
        {
            Console.WriteLine("Ping!!");
            await StudentsManager.AddStudent(newStudent);
            newStudent = new Student();
        }
    }
}