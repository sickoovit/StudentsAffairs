namespace StudentsAffairs.Server.Infrastructure.Repositories;

public class LectureRepository : Repository<Lecture, CourseDbContext>, ILectureRepository
{
    public LectureRepository(CourseDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Lecture>> GetLecturesByCourseId(int courseId)
    {
        return await _context.Lectures
            .Where(l => l.CourseId == courseId)
            .ToListAsync();
    }

    // Get all lectures by ScheduledDate asynchronously
    public async Task<IEnumerable<Lecture>> GetLecturesByScheduledDate(DateTime scheduledDate)
    {
        return await _context.Lectures
            .Where(l => l.ScheduledDate.Date == scheduledDate.Date)
            .ToListAsync();
    }
}
