namespace StudentsAffairs.Server;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<AssignmentSubmission> AssignmentSubmissions { get; set; }

    public DbSet<Course> Courses { get; set; }
    public DbSet<Lecture> Lectures { get; set; }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Tutor> Tutors { get; set; }
    public DbSet<Admin> Admins { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        LectureModelConfiguration(modelBuilder);
        AssignmentModelConfiguration(modelBuilder);
        AssignmentSubmissionModelConfiguration(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    protected void LectureModelConfiguration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Lecture>()
            .HasOne(l => l.Course)
            .WithMany(c => c.Lectures)
            .HasForeignKey(l => l.CourseId);
    }

    protected void AssignmentModelConfiguration(ModelBuilder modelBuilder)
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
    }

    protected void AssignmentSubmissionModelConfiguration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AssignmentSubmission>()
            .HasOne(s => s.Assignment)
            .WithMany(a => a.Submissions)
            .HasForeignKey(s => s.AssignmentId);

        modelBuilder.Entity<AssignmentSubmission>()
            .HasOne(s => s.Student)
            .WithMany()
            .HasForeignKey(s => s.StudentId);
    }
}
