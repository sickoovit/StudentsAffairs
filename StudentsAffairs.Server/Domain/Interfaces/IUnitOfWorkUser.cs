namespace StudentsAffairs.Server.Domain.Interfaces
{
    public interface IUnitOfWorkUser : IDisposable
    {
        IUserRepository Users { get; }
        Task<int> SaveChangesAsync();
    }
}
