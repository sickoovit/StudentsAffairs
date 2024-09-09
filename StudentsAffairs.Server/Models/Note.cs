namespace StudentsAffairs.Server.Models;

public class Note
{
    // Unique identifier for the note.
    public int Id { get; set; }
    // The content or text of the note.
    public string? Content { get; set; }
    // Date and time when the note was created.
    public DateTime CreatedDate { get; set; }
    // Last updated date and time for the note, nullable if the note hasn’t been updated.
    public DateTime? LastUpdatedDate { get; set; }
    // Foreign key to associate the note with a specific course (optional).
    public int? CourseId { get; set; }
    // Foreign key to associate the note with a specific lesson (optional).
    public int? LessonId { get; set; }
    // Flag indicating whether the note is marked as important.
    public bool IsImportant { get; set; }
}
