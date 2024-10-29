using Shared.Endpoints;
using Shared.Helpers;
using System.Net.Http.Json;

namespace Lectures.Client.Managers;

public class LecturesManager
{
	private readonly HttpClient _httpClient;

	public LecturesManager(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<IEnumerable<Lecture>> GetLectures()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetLectures.GetUrl();
			IEnumerable<Lecture> data = await _httpClient.GetFromJsonAsync<IEnumerable<Lecture>>(url);
			return data;
		}
		catch (Exception ex)
		{
			// Handle exception (log it, show a message, etc.)
			Console.WriteLine($"Error fetching lectures: {ex.Message}");
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
