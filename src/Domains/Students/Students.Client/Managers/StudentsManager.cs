using Shared.Endpoints;
using Shared.Helpers;
using System.Net.Http.Json;

namespace Students.Client.Managers;
public class StudentsManager : IStudentsManager
{
	private readonly HttpClient _httpClient;

	public StudentsManager(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<IEnumerable<Student>> GetStudents()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetStudents.GetUrl();
			IEnumerable<Student> data = await _httpClient.GetFromJsonAsync<IEnumerable<Student>>(url);
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
