namespace StudentsAffaires.Models;

public class Student : User
{
    // Student's age.
    public int Age { get; set; }

    // Enrollment date of the student.
    public DateTime EnrollmentDate { get; set; }

    // Nullable graduation date for students who complete their studies.
    public DateTime? GraduationDate { get; set; }

    // List of courses the student is enrolled in.
    public List<Course>? Courses { get; set; }

    // List of Todos assigned to the student.
    public List<Todo>? Todos { get; set; }

    // Notes specific to the student.
    public List<Note>? Notes { get; set; }
}
