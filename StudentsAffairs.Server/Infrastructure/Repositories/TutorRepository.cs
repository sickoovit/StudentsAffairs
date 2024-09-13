namespace StudentsAffairs.Server.Infrastructure.Repositories;

public class TutorRepository : Repository<Student, AppDbContext>, ITutorRepository
{
    public TutorRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Tutor>> GetAllTutorsAsync()
    {
        return await _context.Tutors.ToListAsync();
    }

    public async Task<Tutor?> GetTutorByIdAsync(Guid tutorId)
    {
        return await _context.Tutors.FindAsync(tutorId);
    }

    public async Task AddTutorAsync(Tutor tutor)
    {
        await _context.Tutors.AddAsync(tutor);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTutorAsync(Tutor tutor)
    {
        _context.Tutors.Update(tutor);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTutorAsync(Guid tutorId)
    {
        var tutor = await _context.Tutors.FindAsync(tutorId);
        if (tutor != null)
        {
            _context.Tutors.Remove(tutor);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Tutor>> GetTutorsByCourseAsync(Guid courseId)
    {
        return await _context.Tutors
            .Where(t => t.Courses.Any(c => c.Id == courseId))
            .ToListAsync();
        
    }
}
