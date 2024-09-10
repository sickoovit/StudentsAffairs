namespace StudentsAffairs.Server.Domain.Entities;

public class Lecture
{
    public int Id { get; set; }  // Unique identifier for the lecture
    public string? Title { get; set; }  // Title of the lecture
    public string? Description { get; set; }  // Short description of what the lecture covers
    public DateTime? ScheduledDate { get; set; }  // The scheduled date and time for the lecture
    public TimeSpan? Duration { get; set; }  // Duration of the lecture
    public string? VideoUrl { get; set; }  // Optional URL for lecture video if available

    // Relationships
    public int CourseId { get; set; }  // Foreign key to the associated course
    public Course? Course { get; set; }  // Navigation property for the associated course
}
