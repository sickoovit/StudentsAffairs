namespace Cache;

public interface ICacheService
{
    T UpdateOrAdd<T>(string key, Func<T> fetchFunction);
    T GetOrAdd<T>(string key, Func<T> fetchFunction);
    Task<T> GetOrAddAsync<T>(string key, Func<Task<T>> fetchFunction);
    void ClearCache(string key);
    void ClearAll();
}
