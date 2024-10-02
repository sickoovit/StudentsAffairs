WebAssemblyHostBuilder webAssemblyHostBuilder = WebAssemblyHostBuilder.CreateDefault(args);

webAssemblyHostBuilder.Services.AddLocalization();

await webAssemblyHostBuilder.Build().RunAsync();
