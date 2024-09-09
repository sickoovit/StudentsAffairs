namespace StudentsAffairs.Server.Models;

public class Assignment
{
    // Unique identifier for each assignment.
    public int Id { get; set; }

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

    // The course to which this assignment belongs.
    public int CourseId { get; set; }

    // Navigation property to the course this assignment belongs to.
    public Course? Course { get; set; }

    // List of student submissions for this assignment.
    public List<AssignmentSubmission>? Submissions { get; set; }
}

