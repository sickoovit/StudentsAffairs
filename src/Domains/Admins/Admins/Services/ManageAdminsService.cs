using Admins.Repositories;
using Cache;

namespace Admins.Services;

public class ManageAdminsService : IManageAdminsService
{
	private readonly IAdminRepository _adminRepository;
	private readonly ICacheService _cacheService;

	public ManageAdminsService(IAdminRepository adminRepository, ICacheService cacheService)
	{
		_adminRepository = adminRepository;
		_cacheService = cacheService;
	}

	public async Task<IEnumerable<Admin>> GetAdminsAsync() =>
		await _cacheService.GetOrAddAsync("admins", _adminRepository.GetAllAsync);
}