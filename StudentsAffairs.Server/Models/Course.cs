namespace StudentsAffairs.Server.Models;

public class Course
{
    public int Id { get; set; } // Unique identifier for the course.
    public string? Title { get; set; } // The title or name of the course (e.g., "Introduction to Programming").
    public string? Description { get; set; } // A brief description providing an overview of the course content.
    public string? Category { get; set; } // Category or type of course (e.g., "Programming", "Design", "Marketing").
    public TimeSpan? Duration { get; set; } // The duration or length of the course, represented in hours or minutes.
    public string? Level { get; set; } // Difficulty level of the course (e.g., Beginner, Intermediate, Advanced).
    public decimal? Price { get; set; }  // The price of the course. Nullable in case the course is free or price is not set.

    // Relationships
    public List<Material>? Materials { get; set; } // Materials associated with the course, such as videos, PDFs, or other resources.
    public List<Assignment>? Assignments { get; set; } // List of assignments associated with the course.
    //public List<Module> Modules { get; set; }
    //public List<Lesson> Lessons { get; set; }
    //public int InstructorId { get; set; }

    //// Metadata
    //public DateTime CreatedDate { get; set; }
    //public DateTime LastUpdatedDate { get; set; }
    //public List<string> Tags { get; set; }

    //// Enrollment and Reviews
    //public bool IsPublished { get; set; }
    //public int? EnrollmentLimit { get; set; }
    //public List<Student> EnrolledStudents { get; set; }
    //public float Rating { get; set; }
    //public List<Review> Reviews { get; set; }

    //// Optional
    //public List<Course> Prerequisites { get; set; }
    //public bool CertificateAvailable { get; set; }
    //public string Language { get; set; }
}
