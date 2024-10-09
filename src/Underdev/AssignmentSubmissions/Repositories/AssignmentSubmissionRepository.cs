
using Shared.Data;

namespace AssignmentSubmissions.Repositories
{
	public class AssignmentSubmissionRepository : Repository<AssignmentSubmission>, IAssignmentSubmissionRepository
	{
		public AssignmentSubmissionRepository(AppDbContext context) : base(context)
		{
		}
	}
}
