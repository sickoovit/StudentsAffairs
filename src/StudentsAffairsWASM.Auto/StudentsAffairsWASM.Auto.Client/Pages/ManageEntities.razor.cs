using Assignments.Entities;
using Courses.Entities;
using Lectures.Entities;

namespace StudentsAffairsWASM.Auto.Client.Components.Pages;

public partial class ManageEntities
{

	// Entity class used in the form
	private IEnumerable<Assignment> assignments = new List<Assignment>();
	private IEnumerable<User> users = new List<User>();
	private IEnumerable<Course> courses = new List<Course>();
	private IEnumerable<Lecture> lectures = new List<Lecture>();

	private bool isLoading;

	protected async override Task OnInitializedAsync()
	{
		isLoading = true;

		await base.OnInitializedAsync();
	}

	protected async override Task OnAfterRenderAsync(bool firstRender)
	{
		if (firstRender)
		{
			isLoading = true;
			// TODO: Get Entities
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