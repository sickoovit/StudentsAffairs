namespace StudentsAffairs.MediatR.Queries;

public record GetAssignmentsQuery() : IRequest<IEnumerable<Assignment>>;
