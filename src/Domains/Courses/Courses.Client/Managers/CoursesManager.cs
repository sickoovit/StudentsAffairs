using Shared.Endpoints;
using Shared.Helpers;
using System.Net.Http.Json;

namespace Courses.Client.Managers;

public class CoursesManager : ICoursesManager
{
	private readonly HttpClient _httpClient;

	public CoursesManager(HttpClient httpClient)
	{
		_httpClient = httpClient;
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
