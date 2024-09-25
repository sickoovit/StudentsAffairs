namespace Shared.EntityConfigurations;
public class IdEntityBaseConfiguration : IEntityTypeConfiguration<IdEntity>
{
    public void Configure(EntityTypeBuilder<IdEntity> builder)
    {
        builder.HasKey(u => u.Id);

        builder.HasIndex(u => u.Id);
    }
}