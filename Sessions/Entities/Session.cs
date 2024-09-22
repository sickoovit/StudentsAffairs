namespace Sessions.Entities;

public class Session : IdEntity, TutorReference
{
	List<Guid>? StudentsIds { get; set; }
}
