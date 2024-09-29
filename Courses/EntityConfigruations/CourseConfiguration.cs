namespace Courses.EntityConfigurations;

public class CourseConfiguration : IdEntityBaseConfiguration<Course>
{
	public override void Configure(EntityTypeBuilder<Course> builder)
	{
        builder.ToTable(nameof(Course) + "s");
        // Configure properties
        builder.Property(c => c.Title)
			   .IsRequired()
			   .HasMaxLength(200); // Set title as required with a max length

		builder.Property(c => c.Description)
			   .HasMaxLength(1000); // Optional description with a max length

		builder.Property(c => c.Category)
			   .HasMaxLength(100); // Optional category with a max length

		builder.Property(c => c.Duration)
			   .IsRequired(false); // Duration is optional

		builder.Property(c => c.Level)
			   .HasMaxLength(50); // Optional level with a max length

		builder.Property(c => c.Price)
			   .HasPrecision(10, 2); // Set precision for price

		builder.HasIndex(c => c.Title);
		builder.HasIndex(c => c.Category);

        base.Configure(builder);

        //// Relationships
        //builder.HasMany<Material>() // Assuming you have a Material entity
        //	   .WithMany() // Assuming a course can have many materials
        //	   .UsingEntity(j => j.ToTable("CourseMaterials")); // Join table if necessary

        //builder.HasMany<Assignment>() // Assuming you have an Assignment entity
        //	   .WithMany() // Assuming a course can have many assignments
        //	   .UsingEntity(j => j.ToTable("CourseAssignments")); // Join table if necessary

        //builder.HasMany<Lecture>() // Assuming you have a Lecture entity
        //	   .WithMany() // Assuming a course can have many lectures
        //	   .UsingEntity(j => j.ToTable("CourseLectures")); // Join table if necessary
    }
}
