using Shared.Data;

namespace Tutors.Repositories;

public class TutorRepository : Repository<Tutor>, ITutorRepository
{
    public TutorRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Tutor>> GetTutorsByCourseAsync(Guid courseId)
    {
        throw new NotImplementedException();
        
    }
}
