namespace Shared.Validators;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(user => user.Username)
            .NotEmpty().WithMessage("Username is required.")
            .MinimumLength(5).WithMessage("Username must be at least 5 characters long.");

        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.");

        RuleFor(user => user.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MinimumLength(8).WithMessage("Password must be at least 8 characters long.");

        RuleFor(user => user.Mobile)
            .Matches(@"^\d{10}$").WithMessage("Mobile number must be 10 digits.")
            .When(user => !string.IsNullOrEmpty(user.Mobile));

        RuleFor(user => user.CreatedAt)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Created date cannot be in the future.");
    }
}