namespace StudentsAffaires.Models;

public class Material
{
    public int Id { get; set; } // Unique identifier for the material
    public string? Title { get; set; } // Title or name of the material
    public string? Description { get; set; } // Brief description of the material's content
    public string? Type { get; set; } // Type of material (e.g., PDF, Video, Link, etc.)
    public string? FileUrl { get; set; } // URL or path to the material file
    public DateTime? UploadedDate { get; set; } // Date when the material was uploaded
    public bool IsDownloadable { get; set; } // Indicates if the material can be downloaded
    public int CourseId { get; set; } // Foreign key to link the material to a course
    public Course? Course { get; set; } // Navigation property for the course the material belongs to.
    public List<Student>? Students { get; set; } // Navigation property for the students who has access to the material.
}
