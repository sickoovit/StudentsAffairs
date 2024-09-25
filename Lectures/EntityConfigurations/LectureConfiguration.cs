using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Lectures.EntityConfigurations;

public class LectureConfiguration : IEntityTypeConfiguration<Lecture>
{
	public void Configure(EntityTypeBuilder<Lecture> builder)
	{
		builder.ToTable(nameof(Lecture)+"s");
        // Configure properties
        builder.Property(l => l.Title)
			   .IsRequired()
			   .HasMaxLength(200); // Set title as required with a max length

		builder.Property(l => l.Description)
			   .HasMaxLength(1000); // Optional description with a max length

		builder.Property(l => l.ScheduledDate)
			   .IsRequired(); // ScheduledDate is required

		builder.Property(l => l.Duration)
			   .IsRequired(false); // Duration is optional

		builder.Property(l => l.VideoUrl)
			   .HasMaxLength(500); // Optional Video URL with a max length

		builder.HasIndex(l => l.Title);
		builder.HasIndex(l => l.ScheduledDate);

		//// Relationships
		//builder.HasOne<Course>() // Assuming you have a Course entity
		//	   .WithMany() // Assuming a course can have many lectures
		//	   .HasForeignKey(l => l.CourseId) // Linking to the CourseId property
		//	   .OnDelete(DeleteBehavior.Cascade); // Optional: Configure delete behavior
	}
}
