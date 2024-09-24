namespace Shared.EntityConfigurations;

public class IdEntityBaseConfiguration<T> : IEntityTypeConfiguration<T> where T : IdEntity
{
	public void Configure(EntityTypeBuilder<T> builder)
	{
		// Primary key
		builder.HasKey(u => u.Id);

		builder.HasIndex(u => u.Id);
	}
}