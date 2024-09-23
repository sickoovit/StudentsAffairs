var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddBlazoredSessionStorage();

builder.Configuration.AddUserSecrets<Program>();

string connectionStringAppDbConfigurationKey = "AppDbConnectionString";
string connectionStringAppDb = builder.Configuration[connectionStringAppDbConfigurationKey] ??
    throw new ArgumentNullException(
        paramName: "connectionStringAppDbConfigurationKey",
        message: "Connection String Couldn't Be Resolved. Configuration Key may be not valid"
    );

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(connectionStringAppDb),
    ServiceLifetime.Scoped);

builder.Services.AddScoped<IUserRepository, UserRepository<AppDbContext>>();

builder.Services.AddScoped<IStudentRepository, StudentRepository<AppDbContext>>();
builder.Services.AddScoped<IAdminRepository, AdminRepository<AppDbContext>>();
builder.Services.AddScoped<ITutorRepository, TutorRepository<AppDbContext>>();

builder.Services.AddScoped<ICourseRepository, CourseRepository<AppDbContext>>();
builder.Services.AddScoped<IAssignmentRepository, AssignmentRepository<AppDbContext>>();
builder.Services.AddScoped<ILectureRepository, LectureRepository<AppDbContext>>();

builder.Services.AddScoped<ISessionRepository, SessionRepository>();

builder.Services.AddSingleton<ICacheServiceRepository, CacheServiceRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
