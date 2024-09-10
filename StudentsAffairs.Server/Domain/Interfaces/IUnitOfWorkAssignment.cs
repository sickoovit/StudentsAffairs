namespace StudentsAffairs.Server.Domain.Interfaces;


    public interface IUnitOfWorkAssignment : IDisposable
    {
        ICourseRepository Courses { get; }
        IAssignmentRepository Assignments { get; }
        IMaterialRepository Materials { get; }
        Task<int> SaveChangesAsync();
    }

