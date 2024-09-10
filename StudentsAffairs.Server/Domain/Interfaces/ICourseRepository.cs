namespace StudentsAffairs.Server.Domain.Interfaces;

public interface ICourseRepository : IRepository<Course>
{
    Task<IEnumerable<Course>> GetCoursesWithLecturesAsync();
    Task<IEnumerable<Course>> GetCoursesByCategoryAsync(string category);
    Task<Course?> GetCourseByTitleAsync(string title);
}
