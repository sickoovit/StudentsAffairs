namespace Admins.Entities;

public class Admin : User
{
    public Admin(string Role = "Admin") : base(Role)
    {
    }

    // Role of the admin in the system (e.g., "System Admin", "Course Manager").
    public string? AdminRole { get; set; }
}
