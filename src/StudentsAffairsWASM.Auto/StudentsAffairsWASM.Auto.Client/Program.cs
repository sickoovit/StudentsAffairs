WebAssemblyHostBuilder webAssemblyHostBuilder = WebAssemblyHostBuilder.CreateDefault(args);

webAssemblyHostBuilder.Services.AddHttpClient<IManageEntitiesManager, ManageEntitiesManager>();
webAssemblyHostBuilder.Services.AddHttpClient<IAdminsManager, AdminsManager>();
webAssemblyHostBuilder.Services.AddHttpClient<IAssignmentsManager, AssignmentsManager>();
webAssemblyHostBuilder.Services.AddHttpClient<ICoursesManager, CoursesManager>();
webAssemblyHostBuilder.Services.AddHttpClient<ILecturesManager, LecturesManager>();
webAssemblyHostBuilder.Services.AddHttpClient<IStudentsManager, StudentsManager>();
webAssemblyHostBuilder.Services.AddHttpClient<ITutorsManager, TutorsManager>();

webAssemblyHostBuilder.Services.AddScoped<IManageEntitiesManager, ManageEntitiesManager>();
webAssemblyHostBuilder.Services.AddScoped<IAdminsManager, AdminsManager>();
webAssemblyHostBuilder.Services.AddScoped<IAssignmentsManager, AssignmentsManager>();
webAssemblyHostBuilder.Services.AddScoped<ICoursesManager, CoursesManager>();
webAssemblyHostBuilder.Services.AddScoped<ILecturesManager, LecturesManager>();
webAssemblyHostBuilder.Services.AddScoped<IStudentsManager, StudentsManager>();
webAssemblyHostBuilder.Services.AddScoped<ITutorsManager, TutorsManager>();

await webAssemblyHostBuilder.Build().RunAsync();
