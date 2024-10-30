using Shared.Endpoints;
using Shared.Helpers;
using System.Net.Http.Json;

namespace Assignments.Client.Managers;

public class AssignmentsManager : IAssignmentsManager
{
	private readonly HttpClient _httpClient;

	public AssignmentsManager(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}
	public async Task<IEnumerable<Assignment>> GetAssignments()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetAssignments.GetUrl();
			IEnumerable<Assignment> data = await _httpClient.GetFromJsonAsync<IEnumerable<Assignment>>(url);
			return data;
		}
		catch (Exception ex)
		{
			// Handle exception (log it, show a message, etc.)
			Console.WriteLine($"Error fetching assignments: {ex.Message}");
			return null; // Or throw if you'd rather handle it upstream
		}
	}
	public async Task<IEnumerable<Course>> GetCourses()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetCourses.GetUrl();
			IEnumerable<Course> data = await _httpClient.GetFromJsonAsync<IEnumerable<Course>>(url);
			return data;
		}
		catch (Exception ex)
		{
			// Handle exception (log it, show a message, etc.)
			Console.WriteLine($"Error fetching courses: {ex.Message}");
			return null; // Or throw if you'd rather handle it upstream
		}
	}
}
