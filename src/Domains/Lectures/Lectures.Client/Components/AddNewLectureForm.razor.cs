using Lectures.Client.Managers;

namespace Lectures.Client.Components;

public partial class AddNewLectureForm
{
	[Inject]
    private ILecturesManager? LecturesManager { get; set; }
	[Inject]
	private ILectureRepository LectureRepository { get; set; }

	private IEnumerable<Course> CoursesList = [];
	private Lecture newLecture = new Lecture
    {
        ScheduledDate = DateTime.Now
    };

	protected async override Task OnInitializedAsync()
	{
		CoursesList = await LecturesManager.GetCourses();
		await base.OnInitializedAsync();
	}

    private async Task AddLecture()
    {
        await LectureRepository.AddAsync(newLecture);
        newLecture = new Lecture(); // Reset the form
    }

    private double? lectureDuration
    {
        get => newLecture.Duration?.TotalHours;
        set => newLecture.Duration = value.HasValue ? TimeSpan.FromHours(value.Value) : null;
    }
}