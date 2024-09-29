namespace Students.EntityConfigurations;

public class StudentConfiguration : UserBaseConfiguration<Student>
{
    public override void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable(nameof(Student) + "s");
        // Configure properties
        builder.Property(s => s.Age)
               .IsRequired(); // Age is required

        builder.Property(s => s.EnrollmentDate)
               .IsRequired(); // EnrollmentDate is required

        builder.Property(s => s.GraduationDate)
               .IsRequired(); // GraduationDate is optional

        base.Configure(builder);
    }
}
