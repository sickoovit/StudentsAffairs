namespace StudentsAffairs.Server.Domain.Entities;

public class Admin : User
{
    // Role of the admin in the system (e.g., "System Admin", "Course Manager").
    public string? AdminRole { get; set; }

    // Permissions the admin has in the system.
    public ICollection<string>? Permissions { get; set; }
}
