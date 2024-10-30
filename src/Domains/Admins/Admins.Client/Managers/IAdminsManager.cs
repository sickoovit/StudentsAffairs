
namespace Admins.Client.Managers
{
	public interface IAdminsManager
	{
		Task<IEnumerable<Admin>> GetAdmins();
	}
}