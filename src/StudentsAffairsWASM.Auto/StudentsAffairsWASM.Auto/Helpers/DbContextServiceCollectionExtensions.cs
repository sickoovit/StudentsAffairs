namespace StudentsAffairsWASM.Auto.Helpers;

public static class DbContextServiceCollectionExtensions
{
    public static IServiceCollection AddAppDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionStringAppDb = configuration["AppDbConnectionString"] ??
            throw new ArgumentNullException(nameof(configuration), "AppDbConnectionString not found in configuration.");

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionStringAppDb)
                   .EnableDetailedErrors()
                   .EnableSensitiveDataLogging()
                   .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking),
                   ServiceLifetime.Scoped);

        return services;
    }
}
