namespace Admins.Entities;

public partial class Admin : User
{
    // Role of the admin in the system (e.g., "System Admin", "Course Manager").
    public string? AdminRole { get; set; }
}
