namespace Students.Client.Components
{
    public partial class AddNewStudentForm
    {
        [Inject] private IStudentRepository? StudentRepo { get; set; }
        
        private Student newStudent = new();
        private async Task HandleValidSubmit()
        {
            await StudentRepo.AddStudentAsync(newStudent);
            newStudent = new Student();
        }
    }
}