namespace Students.Entities;

public class Student : User
{

    // Student's age.
    public int Age { get; set; }

    public DateTime EnrollmentDate { get; set; }

    public DateTime GraduationDate { get; set; }

}
