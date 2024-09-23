namespace Tutors.Repositories;

public class TutorRepository<T> : Repository<Tutor>, ITutorRepository
    where T : DbContext
{
    public TutorRepository(T context) : base(context)
    {
    }

    public async Task<IEnumerable<Tutor>> GetAllTutorsAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<Tutor?> GetTutorByIdAsync(Guid tutorId)
    {
        return await _dbSet.FindAsync(tutorId);
    }

    public async Task AddTutorAsync(Tutor tutor)
    {
        await _dbSet.AddAsync(tutor);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateTutorAsync(Tutor tutor)
    {
        _dbSet.Update(tutor);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteTutorAsync(Guid tutorId)
    {
        var tutor = await _dbSet.FindAsync(tutorId);
        if (tutor != null)
        {
            _dbSet.Remove(tutor);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Tutor>> GetTutorsByCourseAsync(Guid courseId)
    {
        throw new NotImplementedException();
        
    }
}
