namespace StudentsAffaires.Models;

public class AssignmentSubmission
{
    // Unique identifier for each submission.
    public int Id { get; set; }

    // The assignment this submission is associated with.
    public int AssignmentId { get; set; }

    // Navigation property to the assignment.
    public Assignment? Assignment { get; set; }

    // The student who submitted the assignment.
    public Guid StudentId { get; set; }

    // Navigation property to the student.
    public Student? Student { get; set; }

    // The date when the assignment was submitted.
    public DateTime SubmittedAt { get; set; }

    // The score or grade received for the submission.
    public decimal? Score { get; set; }

    // Any comments or feedback provided on the submission.
    public string? Feedback { get; set; }

    // The file or content of the submission (e.g., a URL or file path).
    public string? SubmissionContent { get; set; }
}
