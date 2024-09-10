namespace StudentsAffairs.Server.Domain.Interfaces;

public interface ILectureRepository : IRepository<Lecture>
{
    Task<IEnumerable<Lecture>> GetLecturesByCourseId(int courseId);
    Task<IEnumerable<Lecture>> GetLecturesByScheduledDate(DateTime scheduledDate);
    
}
