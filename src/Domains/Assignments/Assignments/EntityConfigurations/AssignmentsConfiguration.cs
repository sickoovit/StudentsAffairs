namespace Assignments.EntityConfigurations;

public class AssignmentConfiguration : IdEntityBaseConfiguration<Assignment>
{
	public override void Configure(EntityTypeBuilder<Assignment> builder)
	{
		builder.ToTable(nameof(Assignment) + "s");
        // Property configurations for Assignment
        builder.Property(a => a.Title)
			.HasMaxLength(255)
			.IsRequired();

		builder.Property(a => a.Description)
			.HasMaxLength(1000)
			.IsRequired();

		builder.Property(a => a.DueDate)
			.IsRequired();

		builder.Property(a => a.CreatedAt)
			.IsRequired();

		builder.Property(a => a.IsGraded)
			.IsRequired();

		builder.Property(a => a.MaxScore)
			.HasColumnType("decimal")
			.HasPrecision(5, 2)
			.IsRequired();

		builder.Property(a => a.CourseId)
			.IsRequired();

		//builder.Property(a => a.AssignmentSubmissionsIds)
		//	.IsRequired(false);

		builder.HasIndex(a => a.Title);
		builder.HasIndex(a => a.CourseId);

        base.Configure(builder);

    }
}
