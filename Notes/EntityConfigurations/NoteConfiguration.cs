namespace Notes.EntityConfigurations;

public class NoteConfiguration : IEntityTypeConfiguration<Note>
{
	public void Configure(EntityTypeBuilder<Note> builder)
	{
		builder.ToTable(nameof(Note)+"s");
        // Configure properties
        builder.Property(n => n.Content)
			   .IsRequired() // Assuming content is required
			   .HasMaxLength(2000); // Maximum length for the content

		builder.Property(n => n.CreatedDate)
			   .IsRequired(); // CreatedDate is required

		builder.Property(n => n.LastUpdatedDate)
			   .IsRequired(); // LastUpdatedDate is optional

		builder.Property(n => n.IsImportant)
			   .IsRequired(); // IsImportant is required

		builder.Property(n => n.CourseId)
			   .IsRequired(false);

		builder.Property(n => n.LessonId)
			   .IsRequired(false);
	}
}
