namespace AssignmentSubmissions.Entities;

public partial class AssignmentSubmission : IdEntity
{
    // The date when the assignment was submitted.
    public DateTime SubmittedAt { get; set; }

    // The score or grade received for the submission.
    public decimal? Score { get; set; }

    // Any comments or feedback provided on the submission.
    public string? Feedback { get; set; }

    // The file or content of the submission (e.g., a URL or file path).
    public string? SubmissionContent { get; set; }

    public Guid? AssignmentId { get; set; }
	public Guid? StudentId { get; set; }
}
