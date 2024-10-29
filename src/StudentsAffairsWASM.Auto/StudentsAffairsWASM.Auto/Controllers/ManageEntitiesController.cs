using Microsoft.AspNetCore.Mvc;

namespace StudentsAffairsWASM.Auto.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class ManageEntitiesController : ControllerBase
{
	private readonly ManageEntitiesService _manageEntitiesService;

	public ManageEntitiesController(ManageEntitiesService manageEntitiesService)
	{
		_manageEntitiesService = manageEntitiesService;
	}

	[HttpGet]
	public async Task<AllEntitiesDTO> GetAllEntities() => await _manageEntitiesService.GetAllEntitiesAsync();
	
	[HttpGet("students")]
	public async Task<IEnumerable<Student>> GetStudents() => await _manageEntitiesService.GetStudentsAsync();
	[HttpGet("admins")]
	public async Task<IEnumerable<Admin>> GetAdmins() => await _manageEntitiesService.GetAdminsAsync();
	[HttpGet("tutors")]
	public async Task<IEnumerable<Tutor>> GetTutors() => await _manageEntitiesService.GetTutorsAsync();
	[HttpGet("courses")]
	public async Task<IEnumerable<Course>> GetCourses() => await _manageEntitiesService.GetCoursesAsync();
	[HttpGet("assignments")]
	public async Task<IEnumerable<Assignment>> GetAssignments() => await _manageEntitiesService.GetAssignmentsAsync();
	[HttpGet("lectures")]
	public async Task<IEnumerable<Lecture>> GetLectures() => await _manageEntitiesService.GetLecturesAsync();

	[HttpGet("{id}")]
	public string Get(int id) => "value";

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
