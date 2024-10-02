using Assignments.Entities;
using Courses.Entities;
using Lectures.Entities;
using StudentsAffairsWASM.Auto.Client.DTOs;
using System.Net.Http;
using System.Text.Json;

namespace StudentsAffairsWASM.Auto.Client.Components.Pages;

public partial class ManageEntities
{
	private AllEntitiesDTO? data = new AllEntitiesDTO();

	private string selectedRole;
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
            string url = "http://localhost:7207/api/ManageEntitites";
			
			using (HttpClient httpClient = new HttpClient()){
				HttpResponseMessage response = await httpClient.GetAsync(url);

				// Ensure success status code
				response.EnsureSuccessStatusCode();

				// Deserialize the response
				string jsonResponse = await response.Content.ReadAsStringAsync();
				data = JsonSerializer.Deserialize<AllEntitiesDTO>(jsonResponse);
			}
            
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