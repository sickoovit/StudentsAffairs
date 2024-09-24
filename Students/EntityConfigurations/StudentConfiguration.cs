namespace Students.EntityConfigurations;

public class StudentConfiguration : IdEntityBaseConfiguration<Student>
{
	public new void Configure(EntityTypeBuilder<Student> builder)
	{
		base.Configure(builder);

		// Configure properties
		builder.Property(s => s.Age)
			   .IsRequired(); // Age is required

		builder.Property(s => s.EnrollmentDate)
			   .IsRequired(); // EnrollmentDate is required

		builder.Property(s => s.GraduationDate)
			   .IsRequired(false); // GraduationDate is optional

		// Using a value converter to handle the list of CourseIds
		builder.Property(s => s.CourseIds)
			   .HasConversion(
				   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
				   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>())
			   .IsRequired(); // CourseIds is required

		builder.Property(s => s.TodoIds)
			   .HasConversion(
				   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
				   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>())
			   .IsRequired(false); // TodoIds is optional

		builder.Property(s => s.NoteIds)
			   .HasConversion(
				   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
				   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>())
			   .IsRequired(false); // NoteIds is optional
	}
}
