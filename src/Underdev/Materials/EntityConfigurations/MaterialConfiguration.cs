namespace Materials.EntityConfigurations;

public class MaterialConfiguration : IEntityTypeConfiguration<Material>
{
    public void Configure(EntityTypeBuilder<Material> builder)
    {
        builder.ToTable(nameof(Material) + "s");
        // Configure properties
        builder.Property(m => m.Title)
               .IsRequired()
               .HasMaxLength(200); // Set title as required with a max length

        builder.Property(m => m.Description)
               .HasMaxLength(1000); // Optional description with a max length

        builder.Property(m => m.Type)
               .HasMaxLength(100); // Type of material with a max length

        builder.Property(m => m.FileUrl)
               .HasMaxLength(500); // URL or path to the material file with a max length

        builder.Property(m => m.UploadedDate)
               .IsRequired(); // UploadedDate is optional

        builder.Property(m => m.IsDownloadable)
               .IsRequired(); // IsDownloadable is required

        builder.Property(m => m.CourseId)
               .IsRequired();

        builder.HasIndex(m => m.CourseId);
    }
}
