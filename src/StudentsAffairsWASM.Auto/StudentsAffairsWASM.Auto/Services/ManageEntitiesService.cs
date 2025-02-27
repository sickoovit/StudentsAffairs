namespace StudentsAffairsWASM.Auto.Services;

public class ManageEntitiesService : IManageEntitiesService
{
    private readonly IMediator _mediator;

	public ManageEntitiesService(IMediator mediator)
	{
		_mediator = mediator;
	}

	public async Task<AllEntitiesDTO> GetAllEntitiesAsync()
	{
		return new AllEntitiesDTO
		{
			Users = new UsersDTO
			{
				Students = await GetStudentsAsync(),
				Tutors = await GetTutorsAsync(),
				Admins = await GetAdminsAsync()
			},
			Assignments = await GetAssignmentsAsync(),
			Courses = await GetCoursesAsync(),
			Lectures = await GetLecturesAsync()
		};
	}
	public async Task<IEnumerable<Student>> GetStudentsAsync() => await _mediator.Send(new GetStudentsQuery());

	public async Task<IEnumerable<Tutor>> GetTutorsAsync() => await _mediator.Send(new GetTutorsQuery());

    public async Task<IEnumerable<Admin>> GetAdminsAsync() => await _mediator.Send(new GetAdminsQuery());

    public async Task<IEnumerable<Assignment>> GetAssignmentsAsync() => await _mediator.Send(new GetAssignmentsQuery());

    public async Task<IEnumerable<Course>> GetCoursesAsync() =>  await _mediator.Send(new GetCoursesQuery());

    public async Task<IEnumerable<Lecture>> GetLecturesAsync() => await _mediator.Send(new GetLecturesQuery());

	public async Task<IEnumerable<Course>> UpdateCoursesAsync() => throw new NotImplementedException();

	public async Task<IEnumerable<Lecture>> UpdateLecturesAsync() => throw new NotImplementedException();

	public async Task<IEnumerable<Student>> UpdateStudentsAsync() => throw new NotImplementedException();

	public async Task<IEnumerable<Tutor>> UpdateTutorsAsync() => throw new NotImplementedException();

	public async Task<IEnumerable<Admin>> UpdateAdminsAsync() => throw new NotImplementedException();

    public async Task<IEnumerable<Assignment>> UpdateAssignmentsAsync() => throw new NotImplementedException();
}
