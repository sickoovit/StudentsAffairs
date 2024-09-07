namespace BlazorAppInnotech.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(student => student.Name)
                .NotEmpty().WithMessage("Name is required.")
                .Length(2, 50).WithMessage("Name must be between 2 and 50 characters.");

            RuleFor(student => student.Mobile)
                .NotEmpty().WithMessage("Mobile number is required.")
                .Matches(@"^\+?\d{10,15}$").WithMessage("Invalid mobile number format.");

            RuleFor(student => student.Telephone)
                .NotEmpty().WithMessage("Telephone number is required.")
                .Matches(@"^\+?\d{10,15}$").WithMessage("Invalid telephone number format.");

            RuleFor(student => student.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email address.");

            RuleFor(student => student.Age)
                .InclusiveBetween(1, 100);

            //RuleFor(student => student.Message)
            //    .NotEmpty().WithMessage("Message is required.")
            //    .MaximumLength(140).WithMessage("Message cannot exceed 140 characters.");
        }
    }
}
