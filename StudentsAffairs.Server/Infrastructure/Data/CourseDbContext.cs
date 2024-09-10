namespace StudentsAffairs.Server.Infrastructure.Data;
public class CourseDbContext : DbContext
{
    public CourseDbContext(DbContextOptions<CourseDbContext> options)
        : base(options)
    {
    }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Lecture> Lectures { get; set; }

    // Other DbSets...

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure Course-Lecture relationship
        modelBuilder.Entity<Lecture>()
            .HasOne(l => l.Course)
            .WithMany(c => c.Lectures)
            .HasForeignKey(l => l.CourseId);

        // Other model configurations...
    }
}
