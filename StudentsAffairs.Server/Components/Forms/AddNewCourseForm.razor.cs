namespace StudentsAffairs.Server.Components.Forms;

public partial class AddNewCourseForm
{
    private Course newCourse = new Course();

    private int newCourseDurationHours = 0;
    private int newCourseDurationMinutes = 0;
    private int newCourseDurationSeconds = 0;

    [Inject] private ICourseRepository CourseRepo { get; set; }

    private async Task AddCourse()
    {
        newCourse.Duration = new TimeSpan(newCourseDurationHours, newCourseDurationMinutes, newCourseDurationSeconds);
        await CourseRepo.AddAsync(newCourse);
        newCourse = new Course(); // Reset the form
    }
}