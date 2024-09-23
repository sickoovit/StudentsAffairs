namespace Sessions.Entities;

public class Session : IdEntity, IHasTutorReference
{
	public List<Guid>? StudentsIds { get; set; }
	public Guid? TutorId { get; set; }
}
