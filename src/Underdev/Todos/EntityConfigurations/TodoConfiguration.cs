namespace Todos.EntityConfigurations;

public class TodoConfiguration : IEntityTypeConfiguration<Todo>
{
	public void Configure(EntityTypeBuilder<Todo> builder)
	{
        builder.ToTable(nameof(Todo) + "s");
        // Configure properties
        builder.Property(t => t.Title)
			   .IsRequired(); // Title is required

		builder.Property(t => t.Description)
			   .IsRequired(); // Description is required

		builder.Property(t => t.IsCompleted)
			   .IsRequired(); // IsCompleted is required

		builder.Property(t => t.DueDate)
			   .IsRequired(); // DueDate is optional

		builder.Property(t => t.Priority)
			   .IsRequired(); // Priority is optional

		builder.Property(t => t.StudentId)
			   .IsRequired(); // StudentId is required

		builder.Property(t => t.CourseId)
			   .IsRequired(false); // CourseId is optional

		builder.Property(t => t.LessonId)
			   .IsRequired(false); // LessonId is optional
	}
}
