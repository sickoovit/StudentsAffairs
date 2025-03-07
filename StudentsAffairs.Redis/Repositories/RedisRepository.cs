namespace StudentsAffairs.Redis.Repositories;

public class CachedRepository<T> : IRepository<T>, IDisposable
    where T : class
{
    protected readonly IRepository<T> _innerRepository;
    private readonly ICacheService _cacheService;
    private readonly string _cacheKey;
    private static readonly TimeSpan CacheDuration = TimeSpan.FromMinutes(30);

    public CachedRepository(IRepository<T> innerRepository, ICacheService cacheService)
    {
        _innerRepository = innerRepository;
        _cacheService = cacheService;
        _cacheKey = $"{typeof(T).Name}_GetAllAsync";
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        // Try to get data from Redis cache.
        var cachedData = await _cacheService.GetAsync<IEnumerable<T>>(_cacheKey);
        if (cachedData != null)
        {
            return cachedData;
        }

        // If not cached, get from the database.
        var data = await _innerRepository.GetAllAsync();
        // Cache the data for future requests.
        await _cacheService.SetAsync(_cacheKey, data, CacheDuration);
        return data;
    }

    public void Dispose()
    {
        _innerRepository.Dispose();
    }

    public Task<T?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}
