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

	public async Task<IEnumerable<Lecture>> GetTutors()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetTutors.GetUrl();
			IEnumerable<Lecture> data = await _httpClient.GetFromJsonAsync<IEnumerable<Lecture>>(url);
			return data;
		}
		catch (Exception ex)
		{
			// Handle exception (log it, show a message, etc.)
			Console.WriteLine($"Error fetching tutors: {ex.Message}");
			return null; // Or throw if you'd rather handle it upstream
		}
	}

	public async Task<IEnumerable<Lecture>> GetCourses()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetCourses.GetUrl();
			IEnumerable<Lecture> data = await _httpClient.GetFromJsonAsync<IEnumerable<Lecture>>(url);
			return data;
		}
		catch (Exception ex)
		{
			// Handle exception (log it, show a message, etc.)
			Console.WriteLine($"Error fetching tutors: {ex.Message}");
			return null; // Or throw if you'd rather handle it upstream
		}
	}
}
