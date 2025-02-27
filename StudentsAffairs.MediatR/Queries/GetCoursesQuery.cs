namespace StudentsAffairs.MediatR.Queries;

public record GetCoursesQuery() : IRequest<IEnumerable<Course>>;
