namespace StudentsAffairs.Server.Helpers;
public static class ModelBuilderExtensions
{
	public static void ApplyConfigurationsFromApp(this ModelBuilder modelBuilder, Assembly mainAssembly)
	{
		Assembly[] referencedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
		foreach (Assembly assembly in referencedAssemblies){
            string assemblyTitle = assembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title ?? "";
            if (!assemblyTitle.StartsWith("Innotech.StudentsAffairs.Entities")) continue;
            var configurations = assembly.GetTypes()
            .Where(type => typeof(IEntityTypeConfiguration<>).IsAssignableFrom(type) && !type.IsAbstract)
            .ToList();

            // Iterate through each configuration and apply it
            foreach (var config in configurations)
            {
                // Create an instance of the configuration
                var instance = Activator.CreateInstance(config);
                // Use reflection to call ApplyConfiguration
                var applyConfigurationMethod = typeof(ModelBuilder).GetMethod("ApplyConfiguration", new[] { config });
                applyConfigurationMethod?.Invoke(modelBuilder, new[] { instance });
            }
        }
		
	}
}