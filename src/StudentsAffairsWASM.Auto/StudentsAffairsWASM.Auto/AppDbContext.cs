using Admins.Application.Entities;

namespace StudentsAffairsWASM.Auto;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Tutor> Tutors { get; set; }
    public DbSet<Admin> Admins { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		modelBuilder.ApplyConfigurationsFromApp(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
	}
}
