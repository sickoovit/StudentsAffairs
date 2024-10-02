namespace StudentsAffairsWASM.Auto.Client.DTOs;

public class AllEntitiesDTO
{
    public UsersDTO Users { get; set; }
    public IEnumerable<Assignment> Assignments { get; set; }
    public IEnumerable<Course> Courses { get; set; }
    public IEnumerable<Lecture> Lectures { get; set; }
}
