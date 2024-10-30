using Shared.Endpoints;
using Shared.Helpers;
using System.Net.Http.Json;

namespace Tutors.Client.Managers;
public class TutorsManager : ITutorsManager
{
	private readonly HttpClient _httpClient;

	public TutorsManager(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<IEnumerable<Tutor>> GetTutors()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetTutors.GetUrl();
			IEnumerable<Tutor> data = await _httpClient.GetFromJsonAsync<IEnumerable<Tutor>>(url);
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
