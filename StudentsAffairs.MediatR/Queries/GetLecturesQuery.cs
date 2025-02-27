namespace StudentsAffairs.MediatR.Queries;

public record GetLecturesQuery() : IRequest<IEnumerable<Lecture>>;
