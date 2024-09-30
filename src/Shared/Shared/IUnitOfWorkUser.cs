

namespace Shared.UnitsOfWork;

public interface IUnitOfWorkUser : IDisposable
{
    IUserRepository Users { get; }
    Task<int> SaveChangesAsync();
}
