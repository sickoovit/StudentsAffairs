public class UserBaseConfiguration<TUser> : IdEntityBaseConfiguration<TUser> where TUser : User
{
	public new void Configure(EntityTypeBuilder<TUser> builder)
	{
		base.Configure(builder);

		// Property configurations
		builder.Property(u => u.Username)
			.HasMaxLength(50)
			.IsRequired();

		builder.Property(u => u.Name)
			.HasMaxLength(100)
			.IsRequired();

		builder.Property(u => u.Email)
			.HasMaxLength(150)
			.IsRequired();

		builder.Property(u => u.Password)
			.HasMaxLength(255)
			.IsRequired(false);

		builder.Property(u => u.CreatedAt)
			.IsRequired();

		builder.Property(u => u.LastLogin)
			.IsRequired(false);

		builder.Property(u => u.IsActive)
			.IsRequired(false);

		builder.Property(u => u.Mobile)
			.HasMaxLength(20)
			.IsRequired();

		builder.Property(u => u.AvatarUrl)
			.HasMaxLength(255)
			.IsRequired(false);

		builder.HasIndex(u => u.Username);
		builder.HasIndex(u => u.Name);
		builder.HasIndex(u => u.Email);
		builder.HasIndex(u => u.Mobile);
	}
}