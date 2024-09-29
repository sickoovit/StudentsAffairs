namespace Tutors.EntityConfigurations;

public class TutorConfiguration : UserBaseConfiguration<Tutor>
{
    public override void Configure(EntityTypeBuilder<Tutor> builder)
    {
        builder.ToTable(nameof(Tutor) + "s");
        // Configure properties
        builder.Property(t => t.Specialty)
               .IsRequired(false); // Specialty is optional
        
        base.Configure(builder);
    }
}
