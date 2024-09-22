namespace Users.Entities;

public class User : IdEntity
{
    public User()
    {

    }
    public User(string Role)
    {
        this.Role = Role;
    }
    public string? Username { get; set; }

    // Full name of the user.
    public string? Name { get; set; }

    // User's email address for communication.
    public string? Email { get; set; }

    // User's password (hashed for security).
    public string? Password { get; set; }

    // Role of the user (e.g., "Student", "Tutor", "Admin").
    public string? Role { get; set; }

    // Date when the user account was created.
    public DateTime CreatedAt { get; set; }

    // Last login date (nullable, if the user hasn't logged in yet).
    public DateTime? LastLogin { get; set; }

    // Flag to indicate if the user is active.
    public bool IsActive { get; set; }

    // Contact information (optional).
    public string? Mobile { get; set; }

    // Optional avatar URL.
    public string? AvatarUrl { get; set; }

}
