namespace StudentsAffairs.MediatR.Handlers
{
    public class GetLecturesHandler : IRequestHandler<GetLecturesQuery, IEnumerable<Lecture>>
    {
        private readonly ILectureRepository _lectureRepository;

        public GetLecturesHandler(ILectureRepository lectureRepository)
        {
            _lectureRepository = lectureRepository;
        }

        public Task<IEnumerable<Lecture>> Handle(GetLecturesQuery request, CancellationToken cancellationToken)
        {
            return _lectureRepository.GetAllAsync();
        }
    }
}
