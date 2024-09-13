namespace StudentsAffairs.Server.Domain.Interfaces;

public interface IAdminRepository
{
    Task<IEnumerable<Admin>> GetAllAdminsAsync();
    Task<Admin?> GetAdminByIdAsync(Guid adminId);
    Task AddAdminAsync(Admin admin);
    Task UpdateAdminAsync(Admin admin);
    Task DeleteAdminAsync(Guid adminId);
}
