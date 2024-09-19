namespace StudentsAffairs.Server.Entities;

public class Todo
{
    // Unique identifier for the Todo item.
    public int Id { get; set; }
    // Title or short description of the Todo item (e.g., "Complete Chapter 1").
    public string? Title { get; set; }
    // Detailed description or notes about the task to be completed.
    public string? Description { get; set; }
    // Flag indicating whether the task has been completed.
    public bool IsCompleted { get; set; }
    // Due date for completing the task, nullable in case no specific deadline is set.
    public DateTime? DueDate { get; set; }
    // Priority level of the task (e.g., Low, Medium, High), could be an enum.
    public string? Priority { get; set; }
    // Foreign key to associate the Todo item with a specific course.
    public int? CourseId { get; set; }
    // Foreign key to associate the Todo item with a specific lesson (if applicable).
    public int? LessonId { get; set; }
    // Foreign key for the associated student.
    public Guid StudentId { get; set; }
    // Navigation property for the associated student.
    public Student? Student { get; set; }
    // Navigation property for the associated course.
    public Course? Course { get; set; }
}
