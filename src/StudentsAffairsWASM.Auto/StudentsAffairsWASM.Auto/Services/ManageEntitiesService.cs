namespace StudentsAffairsWASM.Auto.Services;

public class ManageEntitiesService : IManageEntitiesService
{
	private readonly IStudentRepository _studentRepository;
	private readonly IAdminRepository _adminRepository;
	private readonly ITutorRepository _tutorRepository;
	private readonly IAssignmentRepository _assignmentRepository;
	private readonly ICourseRepository _courseRepository;
	private readonly ILectureRepository _lectureRepository;
	private readonly ICacheService _cacheService;

	public ManageEntitiesService(
		IStudentRepository studentRepository,
		IAdminRepository adminRepository,
		ITutorRepository tutorRepository,
		IAssignmentRepository assignmentRepository,
		ICourseRepository courseRepository,
		ILectureRepository lectureRepository,
		ICacheService cacheService)
	{
		_studentRepository = studentRepository;
		_adminRepository = adminRepository;
		_tutorRepository = tutorRepository;
		_assignmentRepository = assignmentRepository;
		_courseRepository = courseRepository;
		_lectureRepository = lectureRepository;
		_cacheService = cacheService;
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

	public async void CacheAllEntitiesAsync()
	{
		await GetStudentsAsync();
		await GetAdminsAsync();
		await GetTutorsAsync();
		await GetAssignmentsAsync();
		await GetCoursesAsync();
		await GetLecturesAsync();
	}

	public async Task<IEnumerable<Student>> GetStudentsAsync() =>
		await _cacheService.GetOrAddAsync("students", _studentRepository.GetAllAsync);

	public async Task<IEnumerable<Admin>> GetAdminsAsync() =>
		await _cacheService.GetOrAddAsync("admins", _adminRepository.GetAllAsync);

	public async Task<IEnumerable<Tutor>> GetTutorsAsync() =>
		await _cacheService.GetOrAddAsync("tutors", _tutorRepository.GetAllAsync);

	public async Task<IEnumerable<Assignment>> GetAssignmentsAsync() =>
		await _cacheService.GetOrAddAsync("assignments", _assignmentRepository.GetAllAsync);

	public async Task<IEnumerable<Course>> GetCoursesAsync() =>
		await _cacheService.GetOrAddAsync("courses", _courseRepository.GetAllAsync);

	public async Task<IEnumerable<Lecture>> GetLecturesAsync() =>
		await _cacheService.GetOrAddAsync("lectures", _lectureRepository.GetAllAsync);
}
