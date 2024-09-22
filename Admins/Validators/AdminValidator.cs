namespace Admins.Validators;

public class AdminValidator : AbstractValidator<Admin>
{
    public AdminValidator()
    {
        // Reuse UserValidator for common properties
        Include(new UserValidator());

        // Validate that AdminRole is required and has a maximum length
        RuleFor(admin => admin.AdminRole)
            .NotEmpty().WithMessage("Admin role is required.")
            .MaximumLength(50).WithMessage("Admin role cannot exceed 50 characters.");
    }
}
