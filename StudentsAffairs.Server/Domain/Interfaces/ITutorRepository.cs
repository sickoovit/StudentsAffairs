namespace StudentsAffairs.Server.Domain.Interfaces;

public interface ITutorRepository
{
    Task<IEnumerable<Tutor>> GetAllTutorsAsync();
    Task<Tutor?> GetTutorByIdAsync(Guid tutorId);
    Task AddTutorAsync(Tutor tutor);
    Task UpdateTutorAsync(Tutor tutor);
    Task DeleteTutorAsync(Guid tutorId);
    Task<IEnumerable<Tutor>> GetTutorsByCourseAsync(Guid courseId);
}
