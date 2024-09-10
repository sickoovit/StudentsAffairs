namespace StudentsAffairs.Server.Domain.Interfaces;

public interface IAssignmentRepository : IRepository<Assignment>
{
    Task<IEnumerable<Assignment>> GetAssignmentsByCourseIdAsync(Guid courseId);
}

