namespace Students.EntityConfigurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
	public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable(nameof(Student) + "s");
        // Configure properties
        builder.Property(s => s.Age)
			   .IsRequired(); // Age is required

		builder.Property(s => s.EnrollmentDate)
			   .IsRequired(); // EnrollmentDate is required

		builder.Property(s => s.GraduationDate)
			   .IsRequired(); // GraduationDate is optional

		// Using a value converter to handle the list of CourseIds
		//builder.Property(s => s.CourseIds)
		//	   .HasConversion(
		//		   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
		//		   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>())
		//	   .IsRequired(); // CourseIds is required

		//builder.Property(s => s.TodoIds)
		//	   .HasConversion(
		//		   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
		//		   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>())
		//	   .IsRequired(false); // TodoIds is optional

		//builder.Property(s => s.NoteIds)
		//	   .HasConversion(
		//		   v => JsonSerializer.Serialize(v, JsonSerializerOptions.Default),
		//		   v => JsonSerializer.Deserialize<List<Guid>>(v, JsonSerializerOptions.Default) ?? new List<Guid>())
		//	   .IsRequired(false); // NoteIds is optional
	}
}
