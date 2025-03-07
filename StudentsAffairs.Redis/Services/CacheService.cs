namespace StudentsAffairs.Redis.Services;

public class CacheService : ICacheService
{
    private readonly IDistributedCache _cache;

    public CacheService(IDistributedCache cache)
    {
        _cache = cache;
    }

    public async Task<T?> GetAsync<T>(string key)
    {
        return await _cache.GetRecordAsync<T>(key);
    }

    public async Task SetAsync<T>(string key, T value, TimeSpan expiration)
    {
        await _cache.SetRecordAsync(key, value, expiration);
    }
}
