using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentsAffairsWASM.Auto.Controllers;

[Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
[ApiController]
public class ManageEntitiesController : ControllerBase
{
    [Inject]
    IAssignmentRepository assignmentRepository { get; set; }
    [Inject]
    IStudentRepository studentRepository { get; set; }
    [Inject]
    ITutorRepository tutorRepository { get; set; }
    [Inject]
    IAdminRepository adminRepository { get; set; }
    [Inject]
    ICourseRepository courseRepository { get; set; }
    [Inject]
    ILectureRepository lectureRepository { get; set; }

    // GET: api/<ManageEntitiesController>
    [HttpGet]
    public async Task<AllEntitiesDTO> Get()
    {
        IEnumerable<Student> students = await studentRepository.GetAllStudentsAsync();
        IEnumerable<Admin> admins = await adminRepository.GetAllAdminsAsync();
        IEnumerable<Tutor> tutors = await tutorRepository.GetAllTutorsAsync();
        IEnumerable<Assignment> assignments = await assignmentRepository.GetAllAsync();
        IEnumerable<Course> courses = await courseRepository.GetAllAsync();
        IEnumerable<Lecture> lectures = await lectureRepository.GetAllAsync();

        UsersDTO users = new UsersDTO { 
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


    // GET api/<ManageEntitiesController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ManageEntitiesController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ManageEntitiesController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ManageEntitiesController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
