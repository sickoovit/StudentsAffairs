namespace StudentsAffairs.Server.UnitsOfWork;


public interface IUnitOfWorkAssignment : IDisposable
{
    //ICourseRepository Courses { get; }
    //IAssignmentRepository Assignments { get; }
    //IMaterialRepository Materials { get; }
    Task<int> SaveChangesAsync();
}

