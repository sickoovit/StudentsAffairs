namespace Tutors.Entities;

public class Tutor : User
{
    public Tutor(string Role = "Tutor") : base(Role)
    {
    }

    // List of courses the tutor is teaching.
    public List<Guid>? CoursesIds { get; set; }

    // List of students the tutor is mentoring.
    public List<Guid>? StudentsIds { get; set; }

    // Specialty or area of expertise of the tutor.
    public string? Specialty { get; set; }
}
