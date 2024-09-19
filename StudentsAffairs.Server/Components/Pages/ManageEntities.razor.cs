using Microsoft.AspNetCore.HttpOverrides;


using System.Runtime.CompilerServices;

namespace StudentsAffairs.Server.Components.Pages;

public partial class ManageEntities
{
	[Inject]
	ICacheService cacheService { get; set; }
	[Inject]
	IAssignmentRepository assignmentRepository { get; set; }
	[Inject]
	IUserRepository userRepository { get; set; }
	[Inject]
	ICourseRepository courseRepository { get; set; }
	[Inject]
	ILectureRepository lectureRepository { get; set; }

	// Entity class used in the form
	private IEnumerable<Assignment> assignments = new List<Assignment>();
	private IEnumerable<User> users = new List<User>();
	private IEnumerable<Course> courses = new List<Course>();
	private IEnumerable<Lecture> lectures = new List<Lecture>();

	private bool isLoading;

	protected async override Task OnInitializedAsync()
	{
		isLoading = true;
	}

	protected async override Task OnAfterRenderAsync(bool firstRender)
	{
		if (firstRender)
		{
			isLoading = true;
			assignments = await cacheService.GetOrAdd("assignments", async () =>
			{
				// Fetch data from the database here
				return await assignmentRepository.GetAllAsync();
			});
			courses = await cacheService.GetOrAdd("courses", async () =>
			{
				// Fetch data from the database here
				return await courseRepository.GetAllAsync();
			});
			lectures = await cacheService.GetOrAdd("lectures", async () =>
			{
				// Fetch data from the database here
				return await lectureRepository.GetAllAsync();
			});
			users = await cacheService.GetOrAdd("users", async () =>
			{
				// Fetch data from the database here
				return await userRepository.GetAllAsync();
			});
			isLoading = false;
			StateHasChanged();
		}

		await base.OnAfterRenderAsync(firstRender);
	}

	bool userFormActive = true;
	bool courseFormActive;
	bool lectureFormActive;
	bool assignmentFormActive;

	private void ShowUserForm()
	{
		userFormActive = true;
		courseFormActive = false;
		lectureFormActive = false;
		assignmentFormActive = false;
		StateHasChanged();
	}

	private void ShowCourseForm()
	{
		userFormActive = false;
		courseFormActive = true;
		lectureFormActive = false;
		assignmentFormActive = false;
		StateHasChanged();
	}

	private void ShowLectureForm()
	{
		userFormActive = false;
		courseFormActive = false;
		lectureFormActive = true;
		assignmentFormActive = false;
		StateHasChanged();
	}

	private void ShowAssignmentForm()
	{
		userFormActive = false;
		courseFormActive = false;
		lectureFormActive = false;
		assignmentFormActive = true;
		StateHasChanged();
	}
}