namespace StudentsAffairs.Server.Domain.Interfaces;

public interface ILectureRepository : IRepository<Lecture>
{
    Task<IEnumerable<Lecture>> GetLecturesByCourseId(Guid courseId);
    Task<IEnumerable<Lecture>> GetLecturesByScheduledDate(DateTime scheduledDate);
    
}
