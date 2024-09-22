namespace Students.Data;
public class StudentsDbContext : DbContext
{
	public StudentsDbContext(DbContextOptions<StudentsDbContext> options)
		: base(options) { }

	public DbSet<Student> Students { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Apply entity configurations
		modelBuilder.ApplyConfiguration(new StudentConfiguration());
	}
}

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
	public void Configure(EntityTypeBuilder<Student> builder)
	{
		builder.ToTable("Students");
		builder.HasKey(s => s.Id);
		// Additional configurations
	}
}
