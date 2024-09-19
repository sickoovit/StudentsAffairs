


namespace StudentsAffairs.Server.Components.Forms;

public partial class AddNewLectureForm
{
    private Lecture newLecture = new Lecture
    {
        ScheduledDate = DateTime.Now
    };

    [Parameter]
    public IEnumerable<Course> Courses { get; set; }

    [Inject] private ILectureRepository LectureRepo { get; set; }

    private async Task AddLecture()
    {
        await LectureRepo.AddAsync(newLecture);
        newLecture = new Lecture(); // Reset the form
    }

    private double? lectureDuration
    {
        get => newLecture.Duration?.TotalHours;
        set => newLecture.Duration = value.HasValue ? TimeSpan.FromHours(value.Value) : null;
    }
}