namespace Admins.EntityConfigurations;

public class AdminConfiguration : UserBaseConfiguration<Admin>
{
	public new void Configure(EntityTypeBuilder<Admin> builder)
	{
		// Inherit User base configuration
		base.Configure(builder);

		// Configure Admin-specific properties
		builder.Property(a => a.AdminRole)
			.HasMaxLength(100)
			.IsRequired(false); // AdminRole can be nullable
	}
}
