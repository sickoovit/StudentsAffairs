namespace Admins.EntityConfigurations;

public class AdminConfiguration : UserBaseConfiguration<Admin>
{
    public override void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.ToTable(nameof(Admin) + "s");
        // Configure Admin-specific properties
        builder.Property(a => a.AdminRole)
            .HasMaxLength(100)
            .IsRequired(false); // AdminRole can be nullable

        base.Configure(builder);
    }
}
