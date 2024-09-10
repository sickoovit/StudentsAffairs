namespace StudentsAffairs.Server.Infrastructure.Repositories
{
    public class AssignmentRepository : Repository<Assignment, AssignmentDbContext>, IAssignmentRepository
    {
        public AssignmentRepository(AssignmentDbContext context) : base(context)
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

}
