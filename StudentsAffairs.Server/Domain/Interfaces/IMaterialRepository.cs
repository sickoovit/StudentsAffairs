namespace StudentsAffairs.Server.Domain.Interfaces;

public interface IMaterialRepository : IRepository<Material>
{
    Task<IEnumerable<Material>> GetMaterialsByCourseIdAsync(Guid courseId);
}