WebApplicationBuilder webApplicationBuilder = WebApplication.CreateBuilder(args);

// Add services to the container.
webApplicationBuilder.Services.AddRazorComponents()
	.AddInteractiveServerComponents()
	.AddInteractiveWebAssemblyComponents();

webApplicationBuilder.Services.AddControllers();
webApplicationBuilder.Services.AddBlazoredSessionStorage();

webApplicationBuilder.Configuration.AddUserSecrets<Program>();

string connectionStringAppDbConfigurationKey = "AppDbConnectionString";
string connectionStringAppDb = webApplicationBuilder.Configuration[connectionStringAppDbConfigurationKey] ??
    throw new ArgumentNullException(
        paramName: "connectionStringAppDbConfigurationKey",
        message: "Connection String Couldn't Be Resolved. Configuration Key may be not valid"
    );

webApplicationBuilder.Services.AddDbContext<AppDbContext>(options =>
														  options.UseSqlServer(connectionStringAppDb)
															     .EnableDetailedErrors()
                                                                 .EnableSensitiveDataLogging()
                                                                 .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking),
                                                                 ServiceLifetime.Scoped);

webApplicationBuilder.Services.AddSingleton<ICacheService, CacheService>();

webApplicationBuilder.Services.AddScoped<IStudentRepository, StudentRepository>();
webApplicationBuilder.Services.AddScoped<IAdminRepository, AdminRepository>();
webApplicationBuilder.Services.AddScoped<ITutorRepository, TutorRepository>();

webApplicationBuilder.Services.AddScoped<ICourseRepository, CourseRepository>();
webApplicationBuilder.Services.AddScoped<IAssignmentRepository, AssignmentRepository>();
webApplicationBuilder.Services.AddScoped<ILectureRepository, LectureRepository>();

webApplicationBuilder.Services.AddHttpClient();

webApplicationBuilder.Services.AddScoped<IManageEntitiesService, ManageEntitiesService>();
webApplicationBuilder.Services.AddScoped<IManageEntitiesManager,ManageEntitiesManager>();
webApplicationBuilder.Services.AddScoped<IAdminsManager, AdminsManager>();
webApplicationBuilder.Services.AddScoped<IAssignmentsManager,AssignmentsManager>();
webApplicationBuilder.Services.AddScoped<ICoursesManager, CoursesManager>();
webApplicationBuilder.Services.AddScoped<ILecturesManager, LecturesManager>();
webApplicationBuilder.Services.AddScoped<IStudentsManager, StudentsManager>();
webApplicationBuilder.Services.AddScoped<ITutorsManager, TutorsManager>();

WebApplication webApplication = webApplicationBuilder.Build();

// Configure the HTTP request pipeline.
if (webApplication.Environment.IsDevelopment())
{
	webApplication.UseWebAssemblyDebugging();
}
else
{
	webApplication.UseExceptionHandler("/Error", createScopeForErrors: true);
	webApplication.UseHsts();
}

webApplication.UseHttpsRedirection();

webApplication.UseCors();

webApplication.MapControllers();

webApplication.UseStaticFiles();
webApplication.UseAntiforgery();

webApplication.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode()
	.AddInteractiveWebAssemblyRenderMode()
	.AddAdditionalAssemblies(typeof(StudentsAffairsWASM.Auto.Client._Imports).Assembly);

webApplication.Run();