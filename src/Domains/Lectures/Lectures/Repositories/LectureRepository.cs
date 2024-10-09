namespace Lectures.Repositories;

public class LectureRepository : Repository<Lecture>, ILectureRepository 
{
    public LectureRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Lecture>> GetLecturesByCourseId(Guid courseId)
    {
        return await _dbSet
            .Where(l => l.CourseId == courseId)
            .ToListAsync();
    }

    // Get all lectures by ScheduledDate asynchronously
    public async Task<IEnumerable<Lecture>> GetLecturesByScheduledDate(DateTime scheduledDate)
    {
        return await _dbSet
			.Where(l => l.ScheduledDate.Date == scheduledDate.Date)
            .ToListAsync();
    }
}
