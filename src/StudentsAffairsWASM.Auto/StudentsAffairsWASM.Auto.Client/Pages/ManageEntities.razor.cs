namespace StudentsAffairsWASM.Auto.Client.Components.Pages;

public partial class ManageEntities
{
	[Inject]
	private IManageEntitiesManager ManageEntitiesManager { get; set; }
	private AllEntitiesDTO? data = new AllEntitiesDTO();

	private bool isLoading;
	private string selectedRole = "";

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

			data = await ManageEntitiesManager.GetAllEntities();

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