namespace StudentsAffairs.MediatR.Queries;

public record GetStudentsQuery() : IRequest<IEnumerable<Student>>;
