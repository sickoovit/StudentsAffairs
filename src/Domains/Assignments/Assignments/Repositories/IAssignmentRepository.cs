namespace Assignments.Repositories;

public interface IAssignmentRepository : IRepository<Assignment>
{
    Task<IEnumerable<Assignment>> GetAssignmentsByCourseIdAsync(Guid courseId);
}

