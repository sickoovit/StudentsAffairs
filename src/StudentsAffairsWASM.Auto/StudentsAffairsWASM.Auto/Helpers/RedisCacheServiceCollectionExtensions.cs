namespace StudentsAffairsWASM.Auto.Helpers;

public static class RedisCacheServiceCollectionExtensions
{
    public static IServiceCollection AddRedisCache(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionStringRedis = configuration["RedisConnectionString"] ??
            throw new ArgumentNullException(nameof(configuration), "RedisConnectionString not found in configuration.");

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = connectionStringRedis;
            options.InstanceName = "StudentsAffairs_";
        });

        // Register your ICacheService implementation that wraps IDistributedCache
        services.AddScoped<ICacheService, CacheService>();

        return services;
    }
}
