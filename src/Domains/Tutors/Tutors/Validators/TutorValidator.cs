namespace Tutors.Validators;

using FluentValidation;
using Tutors.Entities;

public class TutorValidator : AbstractValidator<Tutor>
{
    public TutorValidator()
    {
        // Reusing the validation rules from UserValidator for User properties
        Include(new UserValidator());

        // Validating that a tutor must have a specialty
        RuleFor(tutor => tutor.Specialty)
            .NotEmpty().WithMessage("Specialty is required.")
            .MaximumLength(100).WithMessage("Specialty cannot exceed 100 characters.");

        //// Validating the Courses list (should have at least one course)
        //RuleFor(tutor => tutor.Courses)
        //    .NotNull().WithMessage("Courses list cannot be null.")
        //    .Must(courses => courses.Count > 0).WithMessage("Tutor must be assigned to at least one course.")
        //    .When(tutor => tutor.Courses != null);  // Only validate if Courses list is not null

        //// Validating the Students list (can be empty, but should not be null)
        //RuleFor(tutor => tutor.Students)
        //    .NotNull().WithMessage("Students list cannot be null.")
        //    .When(tutor => tutor.Students != null);  // Only validate if Students list is not null
    }
}
