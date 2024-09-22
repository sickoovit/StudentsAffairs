namespace Assignments.Data;
public class AssignmentsDbContext : DbContext
{
	public AssignmentsDbContext(DbContextOptions<AssignmentsDbContext> options)
		: base(options) { }

	public DbSet<Assignment> Assignments { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Apply entity configurations
		modelBuilder.ApplyConfiguration(new StudentConfiguration());
	}
}

public class StudentConfiguration : IEntityTypeConfiguration<Assignment>
{
	public void Configure(EntityTypeBuilder<Assignment> builder)
	{
		builder.ToTable("Assignments");
		builder.HasKey(s => s.Id);
		// Additional configurations
	}
}
