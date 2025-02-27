namespace StudentsAffairs.MediatR.Queries;

public record GetTutorsQuery() : IRequest<IEnumerable<Tutor>>;
