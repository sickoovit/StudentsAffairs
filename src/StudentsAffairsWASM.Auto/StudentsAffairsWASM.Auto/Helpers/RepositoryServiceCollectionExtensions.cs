namespace StudentsAffairsWASM.Auto.Helpers;

public static class RepositoryServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<IStudentRepository, StudentRepository>();
        services.AddScoped<IAdminRepository, AdminRepository>();
        services.AddScoped<ITutorRepository, TutorRepository>();
        services.AddScoped<ICourseRepository, CourseRepository>();
        services.AddScoped<IAssignmentRepository, AssignmentRepository>();
        services.AddScoped<ILectureRepository, LectureRepository>();

        services.TryDecorate(typeof(IRepository<>), typeof(CachedRepository<>));
        services.Decorate<IStudentRepository, CachedStudentRepository>();
        services.Decorate<IAdminRepository, CachedAdminRepository>();
        services.Decorate<ITutorRepository, CachedTutorRepository>();
        services.Decorate<ICourseRepository, CachedCourseRepository>();
        services.Decorate<IAssignmentRepository, CachedAssignmentRepository>();
        services.Decorate<ILectureRepository, CachedLectureRepository>();

        return services;
    }
}
