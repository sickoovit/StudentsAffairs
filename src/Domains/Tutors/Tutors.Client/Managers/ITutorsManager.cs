
namespace Tutors.Client.Managers
{
	public interface ITutorsManager
	{
		Task<IEnumerable<Tutor>> GetTutors();
	}
}