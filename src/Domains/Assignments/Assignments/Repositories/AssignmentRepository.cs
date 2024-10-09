using Shared.Data;

namespace Assignments.Repositories;

public class AssignmentRepository : Repository<Assignment>, IAssignmentRepository
{
	public AssignmentRepository(AppDbContext context) : base(context)
	{
	}

	// Get all assignments by courseId asynchronously
	public async Task<IEnumerable<Assignment>> GetAssignmentsByCourseIdAsync(Guid courseId)
	{
		// Using LINQ to filter assignments by courseId
		return await _dbSet
			.Where(a => a.CourseId == courseId)
			.ToListAsync();
	}
}
