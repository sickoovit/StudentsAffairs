
namespace StudentsAffairsWASM.Auto.Services
{
	public interface IManageEntitiesService
	{
		Task<AllEntitiesDTO> GetAllEntitiesAsync();
		Task<IEnumerable<Assignment>> GetAssignmentsAsync();
		Task<IEnumerable<Course>> GetCoursesAsync();
		Task<IEnumerable<Lecture>> GetLecturesAsync();
		Task<IEnumerable<Student>> GetStudentsAsync();
		Task<IEnumerable<Tutor>> GetTutorsAsync();
		Task<IEnumerable<Admin>> GetAdminsAsync();
		Task<IEnumerable<Assignment>> UpdateAssignmentsAsync();
		Task<IEnumerable<Course>> UpdateCoursesAsync();
		Task<IEnumerable<Lecture>> UpdateLecturesAsync();
		Task<IEnumerable<Student>> UpdateStudentsAsync();
		Task<IEnumerable<Tutor>> UpdateTutorsAsync();
		Task<IEnumerable<Admin>> UpdateAdminsAsync();

	}
}