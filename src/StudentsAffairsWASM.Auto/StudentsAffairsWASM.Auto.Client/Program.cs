WebAssemblyHostBuilder webAssemblyHostBuilder = WebAssemblyHostBuilder.CreateDefault(args);

await webAssemblyHostBuilder.Build().RunAsync();
