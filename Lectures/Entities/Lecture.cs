namespace Lectures.Entities;

public class Lecture : IdEntity
{
    public string? Title { get; set; }  // Title of the lecture
    public string? Description { get; set; }  // Short description of what the lecture covers
    public DateTime ScheduledDate { get; set; }  // The scheduled date and time for the lecture
    public TimeSpan? Duration { get; set; }  // Duration of the lecture
    public string? VideoUrl { get; set; }  // Optional URL for lecture video if available
    public Guid? CourseId { get; set; }
}
