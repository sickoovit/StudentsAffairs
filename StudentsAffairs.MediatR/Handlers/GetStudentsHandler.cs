namespace StudentsAffairs.MediatR.Handlers
{
    public class GetStudentsHandler : IRequestHandler<GetStudentsQuery, IEnumerable<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentsHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task<IEnumerable<Student>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return _studentRepository.GetAllAsync();
        }
    }
}
