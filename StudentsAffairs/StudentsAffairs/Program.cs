using StudentsAffairs.Client.Pages;
using StudentsAffairs.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Configuration.AddUserSecrets<Program>();

string connectionStringUserDbConfigurationKey = "UserDbConnectionString";
string connectionStringUserDb = builder.Configuration[connectionStringUserDbConfigurationKey] ??
    throw new ArgumentNullException(
        paramName: "connectionStringUserDbConfigurationKey",
        message: "Connection String Couldn't Be Resolved. Configuration Key may be not valid"
    );

string connectionStringAssignmentDbConfigurationKey = "AssignmentDbConnectionString";
string connectionStringAssignmentDb = builder.Configuration[connectionStringAssignmentDbConfigurationKey] ??
    throw new ArgumentNullException(
        paramName: "connectionStringAssignmentDbConfigurationKey",
        message: "Connection String Couldn't Be Resolved. Configuration Key may be not valid"
    );

builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(connectionStringUserDb));

builder.Services.AddDbContext<AssignmentDbContext>(options =>
    options.UseSqlServer(connectionStringAssignmentDb));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(StudentsAffairs.Client._Imports).Assembly);

app.Run();
