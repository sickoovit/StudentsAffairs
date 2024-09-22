namespace Notes.Entities;

public class Note : IdEntity, CourseReference, LessonReference
{
    // The content or text of the note.
    public string? Content { get; set; }
    // Date and time when the note was created.
    public DateTime CreatedDate { get; set; }
    // Last updated date and time for the note, nullable if the note hasn’t been updated.
    public DateTime? LastUpdatedDate { get; set; }
    // Flag indicating whether the note is marked as important.
    public bool IsImportant { get; set; }
}
