namespace Students.Entities;

public class Student : User
{

    // Student's age.
    public int Age { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public DateTime? GraduationDate { get; set; }

    // Instead of referencing the Course entity, store the list of Course IDs.
    public List<Guid> CourseIds { get; set; } = new();

    public List<Guid>? TodoIds { get; set; }

    public List<Guid>? NoteIds { get; set; }
}
