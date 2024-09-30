namespace Admins.Entities;

public class Admin : User
{
    // Role of the admin in the system (e.g., "System Admin", "Course Manager").
    public string? AdminRole { get; set; }
}
