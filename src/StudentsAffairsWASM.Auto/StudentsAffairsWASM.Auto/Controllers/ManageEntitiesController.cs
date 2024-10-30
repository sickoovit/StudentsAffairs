using Microsoft.AspNetCore.Mvc;

namespace StudentsAffairsWASM.Auto.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class ManageEntitiesController : ControllerBase
{
	private readonly IManageEntitiesService ManageEntitiesService;

	public ManageEntitiesController(IManageEntitiesService manageEntitiesService)
	{
		ManageEntitiesService = manageEntitiesService;
	}

	[HttpGet]
	public async Task<AllEntitiesDTO> GetAllEntities() => await ManageEntitiesService.GetAllEntitiesAsync();
	
	[HttpGet("students")]
	public async Task<IEnumerable<Student>> GetStudents() => await ManageEntitiesService.GetStudentsAsync();
	[HttpGet("admins")]
	public async Task<IEnumerable<Admin>> GetAdmins() => await ManageEntitiesService.GetAdminsAsync();
	[HttpGet("tutors")]
	public async Task<IEnumerable<Tutor>> GetTutors() => await ManageEntitiesService.GetTutorsAsync();
	[HttpGet("courses")]
	public async Task<IEnumerable<Course>> GetCourses() => await ManageEntitiesService.GetCoursesAsync();
	[HttpGet("assignments")]
	public async Task<IEnumerable<Assignment>> GetAssignments() => await ManageEntitiesService.GetAssignmentsAsync();
	[HttpGet("lectures")]
	public async Task<IEnumerable<Lecture>> GetLectures() => await ManageEntitiesService.GetLecturesAsync();

	[HttpPost]
	public void Post([FromBody] string value)
	{
	}

	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value)
	{
	}

	[HttpDelete("{id}")]
	public void Delete(int id)
	{
	}
}
