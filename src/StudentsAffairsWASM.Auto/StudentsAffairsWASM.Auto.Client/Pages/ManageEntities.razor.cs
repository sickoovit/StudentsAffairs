using Admins.Client.Components;
using Students.Client.Components;
using System.Data;
using System.Diagnostics;
using System.Numerics;
using Tutors.Client.Components;

namespace StudentsAffairsWASM.Auto.Client.Components.Pages;

public partial class ManageEntities
{
	[Inject]
	private ManageEntitiesManager _manager { get; set; }
	private AllEntitiesDTO? data = new AllEntitiesDTO();

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

			data = await _manager.GetAllEntities();

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