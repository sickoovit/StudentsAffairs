namespace StudentsAffairsWASM.Auto.Helpers;
public static class ModelBuilderExtensions
{
    public static void ApplyConfigurationsFromApp(this ModelBuilder modelBuilder, Assembly mainAssembly)
    {
        Assembly[] referencedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (Assembly assembly in referencedAssemblies)
        {
            string assemblyTitle = assembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title ?? "";
            if (!assemblyTitle.StartsWith("Innotech.StudentsAffairs.Entities")) continue;
            var configurations = assembly.GetTypes()
            .Where(type => !type.IsAbstract
                && type.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>)))
            .ToList();

            // Iterate through each configuration and apply it
            foreach (var config in configurations)
            {
                var applyConfigurationMethod = typeof(ModelBuilder)
                .GetMethods()
                .FirstOrDefault(m => m.Name == "ApplyConfiguration"
                && m.GetParameters().Length == 1
                && m.GetParameters()[0].ParameterType.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>));

                if (applyConfigurationMethod != null)
                {
                    // Get the configuration type for your specific entity
                    var entityType = config.GetInterfaces()
                        .First(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                        .GetGenericArguments()[0];

                    // Make the method generic for that entity type
                    var genericMethod = applyConfigurationMethod.MakeGenericMethod(entityType);

                    var configInstance = Activator.CreateInstance(config) ?? new();


                    // Invoke the method, passing the config instance
                    genericMethod.Invoke(modelBuilder, new object[] { configInstance } );
                }

            }
        }

    }
}