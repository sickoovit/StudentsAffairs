using System.Collections.Concurrent;

namespace Cache;

public class CacheService : ICacheService
{
	private ConcurrentDictionary<string, object> _cache = new ConcurrentDictionary<string, object>();

	public T UpdateOrAdd<T>(string key, Func<T> fetchFunction)
	{
		var result = fetchFunction();
		_cache[key] = result;
		return result;
	}

	public T Get<T>(string key, Func<T> fetchFunction)
	{
		if (_cache.TryGetValue(key, out var cachedValue))
		{
			return (T)cachedValue;
		}

		var result = fetchFunction();
		_cache[key] = result;
		return result;
	}

	public async Task<T> GetAsync<T>(string key, Func<Task<T>> fetchFunction)
	{
		if (_cache.TryGetValue(key, out var cachedValue))
		{
			return (T)cachedValue;
		}

		var result = await fetchFunction();
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
		_cache.TryRemove(key, out _);
	}

	public void ClearAll()
	{
		_cache.Clear();
	}
}
