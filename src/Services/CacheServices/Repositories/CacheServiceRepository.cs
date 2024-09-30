namespace CacheService.Repositories;

public class CacheServiceRepository : ICacheServiceRepository
{
    private Dictionary<string, object> _cache = new Dictionary<string, object>();

    public T UpdateOrAdd<T>(string key, Func<T> fetchFunction)
    {
        var result = fetchFunction();
        _cache[key] = result;
        return result;
    }

    public T GetOrAdd<T>(string key, Func<T> fetchFunction)
    {
        if (_cache.ContainsKey(key))
        {
            return (T)_cache[key];
        }

        var result = fetchFunction();
        _cache[key] = result;
        return result;
    }

    public async Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> fetchFunction)
    {
        if (_cache.ContainsKey(key))
        {
            return (T)_cache[key];
        }

        var result = await fetchFunction();
        _cache[key] = result;
        return result;
    }

    public void ClearCache(string key)
    {
        if (_cache.ContainsKey(key))
        {
            _cache.Remove(key);
        }
    }

    public void ClearAll()
    {
        _cache.Clear();
    }
}
