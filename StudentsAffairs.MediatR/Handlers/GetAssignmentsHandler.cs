namespace StudentsAffairs.MediatR.Handlers
{
    public class GetAssignmentsHandler : IRequestHandler<GetAssignmentsQuery, IEnumerable<Assignment>>
    {
        private readonly IAssignmentRepository _assignmentRepository;

        public GetAssignmentsHandler(IAssignmentRepository assignmentRepository)
        {
            _assignmentRepository = assignmentRepository;
        }

        public Task<IEnumerable<Assignment>> Handle(GetAssignmentsQuery request, CancellationToken cancellationToken)
        {
            return _assignmentRepository.GetAllAsync();
        }
    }
}
