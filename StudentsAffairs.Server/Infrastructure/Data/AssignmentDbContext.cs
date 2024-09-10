namespace StudentsAffairs.Server.Infrastructure.Data;

public class AssignmentDbContext : DbContext
{
    public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options)
        : base(options)
    {
    }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<AssignmentSubmission> AssignmentSubmissions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure Assignment
        modelBuilder.Entity<Assignment>()
            .HasOne(a => a.Course)
            .WithMany(c => c.Assignments)
            .HasForeignKey(a => a.CourseId);

        // Configure AssignmentSubmission
        modelBuilder.Entity<AssignmentSubmission>()
            .HasOne(s => s.Assignment)
            .WithMany(a => a.Submissions)
            .HasForeignKey(s => s.AssignmentId);

        modelBuilder.Entity<AssignmentSubmission>()
            .HasOne(s => s.Student)
            .WithMany()
            .HasForeignKey(s => s.StudentId);

        base.OnModelCreating(modelBuilder);
    }
}
