using System.Net.Http.Json;

namespace StudentsAffairsWASM.Auto.Client.Managers;
public class ManageEntitiesManager : IManageEntitiesManager
{
	private readonly HttpClient _httpClient;

	public ManageEntitiesManager(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<AllEntitiesDTO> GetAllEntities()
	{
		try
		{
			string url = "https://localhost:7207/api/ManageEntities";
			AllEntitiesDTO data = await _httpClient.GetFromJsonAsync<AllEntitiesDTO>(url);
			return data;
		}
		catch (Exception ex)
		{
			// Handle exception (log it, show a message, etc.)
			Console.WriteLine($"Error fetching entities: {ex.Message}");
			return null; // Or throw if you'd rather handle it upstream
		}
	}
}
