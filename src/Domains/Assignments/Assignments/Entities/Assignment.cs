namespace Assignments.Entities;

public class Assignment : IdEntity
{
    // Title or name of the assignment.
    public string? Title { get; set; }

    // Detailed description of the assignment.
    public string? Description { get; set; }

    // Due date for the assignment.
    public DateTime DueDate { get; set; }

    // Date when the assignment was created.
    public DateTime CreatedAt { get; set; }

    // Flag indicating whether the assignment has been graded.
    public bool IsGraded { get; set; }

    // The maximum score possible for the assignment.
    public decimal MaxScore { get; set; }
	public Guid? CourseId { get; set; }
}

