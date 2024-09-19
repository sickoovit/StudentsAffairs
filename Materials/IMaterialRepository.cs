

namespace StudentsAffairs.Server.Repositories;

public interface IMaterialRepository : IRepository<Material>
{
    Task<IEnumerable<Material>> GetMaterialsByCourseIdAsync(Guid courseId);
}