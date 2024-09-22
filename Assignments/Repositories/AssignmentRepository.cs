namespace Assignments.Repositories;

public class AssignmentRepository : Repository<Assignment, AssignmentsDbContext>, IAssignmentRepository
{
    public AssignmentRepository(AssignmentsDbContext context) : base(context)
    {
    }

    // Get all assignments by courseId asynchronously
    public async Task<IEnumerable<Assignment>> GetAssignmentsByCourseIdAsync(Guid courseId)
    {
        // Using LINQ to filter assignments by courseId
        return await _context.Assignments
            .Where(a => a.CourseId == courseId)
            .ToListAsync();
    }
}
