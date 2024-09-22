namespace Admins.Data;
public class AdminsDbContext : DbContext
{
	public AdminsDbContext(DbContextOptions<AdminsDbContext> options)
		: base(options) { }

	public DbSet<Admin> Admins { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		// Apply entity configurations
		modelBuilder.ApplyConfiguration(new StudentConfiguration());
	}
}

public class StudentConfiguration : IEntityTypeConfiguration<Admin>
{
	public void Configure(EntityTypeBuilder<Admin> builder)
	{
		builder.ToTable("Admins");
		builder.HasKey(s => s.Id);
		// Additional configurations
	}
}
