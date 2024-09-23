namespace Shared.Entities;

public interface IHasStudentReference
{
	Guid? StudentId { get; set; }
}