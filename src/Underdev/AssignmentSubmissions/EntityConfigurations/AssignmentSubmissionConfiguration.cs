namespace AssignmentSubmissions.EntityConfigurations;

public class AssignmentSubmissionConfiguration : IEntityTypeConfiguration<AssignmentSubmission>
{
	public void Configure(EntityTypeBuilder<AssignmentSubmission> builder)
	{
        builder.ToTable(nameof(AssignmentSubmission) + "s");
        // Configure properties
        builder.Property(a => a.SubmittedAt)
			   .IsRequired(); // The submission date is required

		builder.Property(a => a.Score)
			   .HasPrecision(5, 2); // Precision for the score

		builder.Property(a => a.Feedback)
			   .HasMaxLength(500); // Optional feedback with a max length

		builder.Property(a => a.SubmissionContent)
			   .HasMaxLength(1000); // Optional content with a max length

		// Configure foreign key relationships
		//builder.HasOne<Student>() // Assuming you have a Student entity
		//	   .WithMany() // Assuming a student can have many submissions
		//	   .HasForeignKey(a => a.StudentId) // Foreign key in AssignmentSubmission
		//	   .OnDelete(DeleteBehavior.Cascade); // Optional: define delete behavior

		//builder.HasOne<Assignment>() // Assuming you have an Assignment entity
		//	   .WithMany() // Assuming an assignment can have many submissions
		//	   .HasForeignKey(a => a.AssignmentId) // Foreign key in AssignmentSubmission
		//	   .OnDelete(DeleteBehavior.Cascade); // Optional: define delete behavior
	}
}
