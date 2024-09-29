public class UserBaseConfiguration<T> : IdEntityBaseConfiguration<T> where T : User
{
    public override void Configure(EntityTypeBuilder<T> builder)
    {
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
            .IsRequired();

        builder.Property(u => u.IsActive)
            .IsRequired();

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

        base.Configure(builder);
    }
}