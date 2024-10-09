namespace Shared.Repositories;

public class Repository<T> : IRepository<T>, IDisposable
    where T : class
{
	protected readonly AppDbContext _dbContext;
	protected readonly DbSet<T> _dbSet;

	public Repository(AppDbContext dbContext)
	{
		_dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
	}

	public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
		_dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
			_dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }
}
