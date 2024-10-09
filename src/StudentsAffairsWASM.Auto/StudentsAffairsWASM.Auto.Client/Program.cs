WebAssemblyHostBuilder webAssemblyHostBuilder = WebAssemblyHostBuilder.CreateDefault(args);

webAssemblyHostBuilder.Services.AddHttpClient<ManageEntitiesManager>();
webAssemblyHostBuilder.Services.AddScoped<ManageEntitiesManager>();

await webAssemblyHostBuilder.Build().RunAsync();
