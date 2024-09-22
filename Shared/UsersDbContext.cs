namespace Shared.Data;

public class UsersDbContext : DbContext
{
	public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
	{
	}

	public DbSet<User> Users { get; set; }
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		// Configure User entity if needed
		modelBuilder.Entity<User>(entity =>
		{
			entity.ToTable("Users"); // Optional: specify the table name
			entity.HasKey(u => u.Id); // Ensure Id is the primary key
		});
	}
}