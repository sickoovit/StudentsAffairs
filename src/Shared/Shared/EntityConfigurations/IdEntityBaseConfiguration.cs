namespace Shared.EntityConfigurations;
public class IdEntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : IdEntity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => u.Id);
    }
}