namespace StudentsAffaires;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Tutor> Tutors { get; set; }
    public DbSet<Admin> Admins { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure TPH inheritance for the User class
        modelBuilder.Entity<User>()
            .HasDiscriminator<string>("UserType")
            .HasValue<Student>("Student")
            .HasValue<Tutor>("Tutor")
            .HasValue<Admin>("Admin");

        base.OnModelCreating(modelBuilder);
    }
}
