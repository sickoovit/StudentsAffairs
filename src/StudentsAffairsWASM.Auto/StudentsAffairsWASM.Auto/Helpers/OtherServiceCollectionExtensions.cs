namespace StudentsAffairsWASM.Auto.Helpers
{
    public static class OtherServiceCollectionExtensions
    {
        public static IServiceCollection AddOtherServices(this IServiceCollection services)
        {
            services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            services.AddControllers();
            services.AddBlazoredSessionStorage();

            services.AddHttpClient();
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(MediatREntrypoint).Assembly));

            return services;
        }
    }
}
