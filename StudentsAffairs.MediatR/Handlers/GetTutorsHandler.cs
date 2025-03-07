namespace TutorsAffairs.MediatR.Handlers
{
    public class GetTutorsHandler : IRequestHandler<GetTutorsQuery, IEnumerable<Tutor>>
    {
        private readonly ITutorRepository _tutorRepository;

        public GetTutorsHandler(ITutorRepository tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }

        public Task<IEnumerable<Tutor>> Handle(GetTutorsQuery request, CancellationToken cancellationToken)
        {
            return _tutorRepository.GetAllAsync();
        }
    }
}
