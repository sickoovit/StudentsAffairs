﻿
namespace StudentsAffairsWASM.Auto.Services
{
	public interface IManageEntitiesService
	{
		void CacheAllEntitiesAsync();
		Task<AllEntitiesDTO> GetAllEntitiesAsync();
		Task<IEnumerable<Assignment>> GetAssignmentsAsync();
		Task<IEnumerable<Course>> GetCoursesAsync();
		Task<IEnumerable<Lecture>> GetLecturesAsync();
		Task<IEnumerable<Student>> GetStudentsAsync();
		Task<IEnumerable<Tutor>> GetTutorsAsync();
		Task<IEnumerable<Admin>> GetAdminsAsync();

	}
}