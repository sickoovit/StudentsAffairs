namespace StudentsAffairs.Server.Entities;

public class Tutor : User
{
    public Tutor(string Role = "Tutor") : base(Role)
    {
    }

    // List of courses the tutor is teaching.
    public List<Course>? Courses { get; set; }

    // List of students the tutor is mentoring.
    public List<Student>? Students { get; set; }

    // Specialty or area of expertise of the tutor.
    public string? Specialty { get; set; }
}
