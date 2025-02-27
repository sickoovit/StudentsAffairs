namespace StudentsAffairs.MediatR.Queries;

public record GetAdminsQuery() : IRequest<IEnumerable<Admin>>;
