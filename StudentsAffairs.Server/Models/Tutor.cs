namespace StudentsAffairs.Server.Models;

public class Tutor : User
{
    // List of courses the tutor is teaching.
    public List<Course>? Courses { get; set; }

    // List of students the tutor is mentoring.
    public List<Student>? Students { get; set; }

    // Specialty or area of expertise of the tutor.
    public string? Specialty { get; set; }
}
