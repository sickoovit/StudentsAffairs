using Shared.Endpoints;

namespace Shared.Helpers;

public static class ManageEntitiesApiHelper
{
	private const string BaseUrl = "https://localhost:7207/api/ManageEntities";

	public static string GetUrl(this ManageEntitiesApiEndpoints endpoint) => endpoint switch
	{
		ManageEntitiesApiEndpoints.GetCourses => $"{BaseUrl}/courses",
		ManageEntitiesApiEndpoints.GetLectures => $"{BaseUrl}/lectures",
		ManageEntitiesApiEndpoints.GetTutors => $"{BaseUrl}/tutors",
		ManageEntitiesApiEndpoints.GetStudents => $"{BaseUrl}/students",
		ManageEntitiesApiEndpoints.GetAdmins => $"{BaseUrl}/admins",
		ManageEntitiesApiEndpoints.GetAssignments => $"{BaseUrl}/assignments",

		_ => throw new ArgumentOutOfRangeException(nameof(endpoint), endpoint, null)
	};
}
