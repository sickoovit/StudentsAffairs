namespace StudentsAffairs.Redis.Helpers
{
    public static class DistributedCacheExtensions
    {
        public static async Task SetRecordAsync<T>(
            this IDistributedCache cache,
            string key,
            T data,
            TimeSpan expiration)
        {
            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = expiration
            };
            var jsonData = JsonSerializer.Serialize(data);
            await cache.SetStringAsync(key, jsonData, options);
        }

        public static async Task<T?> GetRecordAsync<T>(
            this IDistributedCache cache,
            string key)
        {
            var jsonData = await cache.GetStringAsync(key);
            return jsonData == null ? default : JsonSerializer.Deserialize<T>(jsonData);
        }
    }

}
