
namespace Admins.Services
{
	public interface IManageAdminsService
	{
		Task<IEnumerable<Admin>> GetAdminsAsync();
	}
}