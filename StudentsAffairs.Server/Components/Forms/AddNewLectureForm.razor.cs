namespace StudentsAffairs.Server.Components.Forms;

public partial class AddNewLectureForm
{
    private Lecture newLecture = new Lecture();
    private IEnumerable<Course> courses = new List<Course>();

    private bool isLoading;

    [Inject] private ILectureRepository LectureRepo { get; set; }
    [Inject] private ICourseRepository CourseRepo { get; set; }
    [Inject] private ICacheService CacheService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        isLoading = true;
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            courses = await CacheService.GetOrAdd("courses", async () =>
            {

                // Fetch data from the database here
                return await CourseRepo.GetAllAsync();
            });

            isLoading = false;
            StateHasChanged();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    private async Task AddLecture()
    {
        await LectureRepo.AddAsync(newLecture);
        newLecture = new Lecture(); // Reset the form
    }
}