namespace StudentsAffairs.Server.Domain.Interfaces;

public interface IRepository<T> where T : class
{
    Task<T> GetByIdAsync(Guid Id);
    Task<IEnumerable<T>> GetAllAsync();
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
}
