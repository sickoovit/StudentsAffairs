namespace Courses.Client.Components;

public partial class AddNewCourseForm
{
    private Course newCourse = new Course();

    private int newCourseDurationHours = 0;

    [Inject] private ICourseRepository CourseRepo { get; set; }

    private async Task AddCourse()
    {
        newCourse.Duration = new TimeSpan(newCourseDurationHours, 0, 0);
        await CourseRepo.AddAsync(newCourse);
        newCourse = new Course(); // Reset the form
    }
}