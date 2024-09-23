namespace AssignmentSubmissions.Data
{
	public class AssignmentSubmissionConfiguration : IEntityTypeConfiguration<AssignmentSubmission>
	{
		public void Configure(EntityTypeBuilder<AssignmentSubmission> builder)
		{
			// Define the table name
			builder.ToTable("AssignmentSubmissions");

			// Define the primary key
			builder.HasKey(a => a.Id);

			// Define properties and constraints
			builder.Property(a => a.SubmittedAt)
				   .IsRequired();

			builder.Property(a => a.Score)
				   .HasColumnType("decimal(5, 2)");

			builder.Property(a => a.Feedback)
				   .HasMaxLength(1000);

			builder.Property(a => a.SubmissionContent)
				   .HasMaxLength(2000)
				   .IsRequired();


		}
	}
}
