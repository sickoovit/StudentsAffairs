using Tutors.Client.Managers;

WebAssemblyHostBuilder webAssemblyHostBuilder = WebAssemblyHostBuilder.CreateDefault(args);

webAssemblyHostBuilder.Services.AddHttpClient<ManageEntitiesManager>();
webAssemblyHostBuilder.Services.AddHttpClient<TutorsManager>();
webAssemblyHostBuilder.Services.AddScoped<ManageEntitiesManager>();

await webAssemblyHostBuilder.Build().RunAsync();
