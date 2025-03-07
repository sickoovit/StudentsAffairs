namespace StudentsAffairsWASM.Auto.Helpers;

public static class ManagerServiceCollectionExtensions
{
    public static IServiceCollection AddManagers(this IServiceCollection services)
    {
        services.AddScoped<IManageEntitiesService, ManageEntitiesService>();
        services.AddScoped<IManageEntitiesManager, ManageEntitiesManager>();
        services.AddScoped<IAdminsManager, AdminsManager>();
        services.AddScoped<IAssignmentsManager, AssignmentsManager>();
        services.AddScoped<ICoursesManager, CoursesManager>();
        services.AddScoped<ILecturesManager, LecturesManager>();
        services.AddScoped<IStudentsManager, StudentsManager>();
        services.AddScoped<ITutorsManager, TutorsManager>();

        return services;
    }
}
