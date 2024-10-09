using Microsoft.AspNetCore.Mvc;

namespace StudentsAffairsWASM.Auto.Controllers;

[ApiController]
[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
public class ManageEntitiesController : ControllerBase
{

	readonly IAssignmentRepository? _assignmentRepository;
	readonly IStudentRepository? _studentRepository;
	readonly ITutorRepository? _tutorRepository;
	readonly IAdminRepository? _adminRepository;
	readonly ICourseRepository? _courseRepository;
	readonly ILectureRepository? _lectureRepository;

	public ManageEntitiesController(
		IAssignmentRepository assignmentRepository,
		ICourseRepository courseRepository,
		ILectureRepository lectureRepository,
		IAdminRepository adminRepository,
		IStudentRepository studentRepository,
		ITutorRepository tutorRepository)
	{
		_assignmentRepository = assignmentRepository;
		_courseRepository = courseRepository;
		_lectureRepository = lectureRepository;
		_adminRepository = adminRepository;
		_studentRepository = studentRepository;
		_tutorRepository = tutorRepository;
	}



	// GET: api/<ManageEntitiesController>
	[HttpGet]
	public async Task<AllEntitiesDTO> Get()
	{
		IEnumerable<Student> students;
		IEnumerable<Admin> admins;
		IEnumerable<Tutor> tutors;
		IEnumerable<Assignment> assignments;
		IEnumerable<Course> courses;
		IEnumerable<Lecture> lectures;

		students = await _studentRepository.GetAllAsync();
		admins = await _adminRepository.GetAllAsync();
		tutors = await _tutorRepository.GetAllAsync();
		assignments = await _assignmentRepository.GetAllAsync();
		courses = await _courseRepository.GetAllAsync();
		lectures = await _lectureRepository.GetAllAsync();

		UsersDTO users = new UsersDTO
		{
			Students = students,
			Tutors = tutors,
			Admins = admins
		};

		AllEntitiesDTO allEntities = new AllEntitiesDTO
		{
			Users = users,
			Assignments = assignments,
			Courses = courses,
			Lectures = lectures
		};

		return allEntities;
	}

	// GET api/<ManageEntititesController>/5
	[HttpGet("{id}")]
	public string Get(int id)
	{
		return "value";
	}

	// POST api/<ManageEntititesController>
	[HttpPost]
	public void Post([FromBody] string value)
	{
	}

	// PUT api/<ManageEntititesController>/5
	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value)
	{
	}

	// DELETE api/<ManageEntititesController>/5
	[HttpDelete("{id}")]
	public void Delete(int id)
	{
	}
}
