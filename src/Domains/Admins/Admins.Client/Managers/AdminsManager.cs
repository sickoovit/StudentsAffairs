using Shared.Endpoints;
using Shared.Helpers;
using System.Net.Http.Json;

namespace Admins.Client.Managers;

public class AdminsManager : IAdminsManager
{
	private readonly HttpClient _httpClient;

	public AdminsManager(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<IEnumerable<Admin>> GetAdmins()
	{
		try
		{
			string url = ManageEntitiesApiEndpoints.GetAdmins.GetUrl();
			IEnumerable<Admin> data = await _httpClient.GetFromJsonAsync<IEnumerable<Admin>>(url);
			return data;
		}
		catch (Exception ex)
		{
			// Handle exception (log it, show a message, etc.)
			Console.WriteLine($"Error fetching admins: {ex.Message}");
			return null; // Or throw if you'd rather handle it upstream
		}
	}
}
