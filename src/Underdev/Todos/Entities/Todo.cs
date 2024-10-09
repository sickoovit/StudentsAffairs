namespace Todos.Entities;

public partial class Todo : IdEntity
{
    // Title or short description of the Todo item (e.g., "Complete Chapter 1").
    public string? Title { get; set; }
    // Detailed description or notes about the task to be completed.
    public string? Description { get; set; }
    // Flag indicating whether the task has been completed.
    public bool IsCompleted { get; set; }
    // Due date for completing the task, nullable in case no specific deadline is set.
    public DateTime DueDate { get; set; }
    // Priority level of the task (e.g., Low, Medium, High), could be an enum.
    public string? Priority { get; set; }
	public Guid? StudentId { get; set; }
	public Guid? CourseId { get; set; }
	public Guid? LessonId { get; set; }
}
