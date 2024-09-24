namespace Tutors.EntityConfigurations;

public class TutorConfiguration : IdEntityBaseConfiguration<Tutor>
{
	public new void Configure(EntityTypeBuilder<Tutor> builder)
	{
		base.Configure(builder);

		// Configure properties
		builder.Property(t => t.Specialty)
			   .IsRequired(false); // Specialty is optional

		// Configure CoursesIds as a JSON serialized list
		builder.Property(t => t.CoursesIds)
			   .HasConversion(
				   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
				   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>()
			   );

		// Configure StudentsIds as a JSON serialized list
		builder.Property(t => t.StudentsIds)
			   .HasConversion(
				   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
				   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>()
			   );
	}
}
