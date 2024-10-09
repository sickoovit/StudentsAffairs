namespace Materials.Entities;

public partial class Material : IdEntity
{
	public string? Title { get; set; } // Title or name of the material
	public string? Description { get; set; } // Brief description of the material's content
	public string? Type { get; set; } // Type of material (e.g., PDF, Video, Link, etc.)
	public string? FileUrl { get; set; } // URL or path to the material file
	public DateTime UploadedDate { get; set; } // Date when the material was uploaded
	public bool IsDownloadable { get; set; } // Indicates if the material can be downloaded
	//public List<Guid>? StudentIds { get; set; } // List of student IDs who have access to the material
	public Guid? CourseId { get; set; }
}
