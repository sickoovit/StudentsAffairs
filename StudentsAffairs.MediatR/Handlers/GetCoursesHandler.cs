namespace StudentsAffairs.MediatR.Handlers
{
    public class GetCoursesHandler : IRequestHandler<GetCoursesQuery, IEnumerable<Course>>
    {
        private readonly ICourseRepository _courseRepository;

        public GetCoursesHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Task<IEnumerable<Course>> Handle(GetCoursesQuery request, CancellationToken cancellationToken)
        {
            return _courseRepository.GetAllAsync();
        }
    }
}
