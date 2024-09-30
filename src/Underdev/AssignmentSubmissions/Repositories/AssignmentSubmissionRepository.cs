
namespace AssignmentSubmissions.Repositories
{
	public class AssignmentSubmissionRepository : Repository<AssignmentSubmission>, IAssignmentSubmissionRepository
	{
		public AssignmentSubmissionRepository(DbContext context) : base(context)
		{
		}
	}
}
