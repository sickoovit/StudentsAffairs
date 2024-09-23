namespace Shared.Entities;

public interface IHasLessonReference
{
	Guid? LessonId { get; set; }
}
