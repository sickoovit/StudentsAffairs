namespace Notes.EntityConfigurations;

public class NoteConfiguration : IdEntityBaseConfiguration<Note>
{
	public new void Configure(EntityTypeBuilder<Note> builder)
	{
		base.Configure(builder);

		// Configure properties
		builder.Property(n => n.Content)
			   .IsRequired() // Assuming content is required
			   .HasMaxLength(2000); // Maximum length for the content

		builder.Property(n => n.CreatedDate)
			   .IsRequired(); // CreatedDate is required

		builder.Property(n => n.LastUpdatedDate)
			   .IsRequired(false); // LastUpdatedDate is optional

		builder.Property(n => n.IsImportant)
			   .IsRequired(); // IsImportant is required

		builder.Property(n => n.CourseId)
			   .IsRequired(false);

		builder.Property(n => n.LessonId)
			   .IsRequired(false);
	}
}
