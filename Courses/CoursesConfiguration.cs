namespace Courses.Entities
{
	public class CourseConfiguration : IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			// Configure table name if needed
			builder.ToTable("Courses");

			// Configure properties
			builder.HasKey(c => c.Id); // Assuming Id is inherited from IdEntity

			builder.Property(c => c.Title)
				   .IsRequired() // Make required if needed
				   .HasMaxLength(100); // Set a max length

			builder.Property(c => c.Description)
				   .HasMaxLength(500); // Set a max length for description

			builder.Property(c => c.Category)
				   .HasMaxLength(50); // Set a max length for category

			builder.Property(c => c.Duration)
				   .IsRequired(false); // Nullable, so no need for IsRequired

			builder.Property(c => c.Level)
				   .HasMaxLength(20); // Set a max length for level

			builder.Property(c => c.Price)
				   .HasColumnType("decimal(18,2)"); // Configure price as decimal

			// Configure lists of IDs as needed, though they won't have relationships
			builder.Property(c => c.MaterialsIds)
				   .HasConversion(
					   v => string.Join(',', v), // Convert list to comma-separated string for storage
					   v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(Guid.Parse).ToList()); // Convert back to list

			builder.Property(c => c.AssignmentsIds)
				   .HasConversion(
					   v => string.Join(',', v),
					   v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(Guid.Parse).ToList());

			builder.Property(c => c.LecturesIds)
				   .HasConversion(
					   v => string.Join(',', v),
					   v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(Guid.Parse).ToList());
		}
	}
}
