namespace Students.Validators;

public class StudentValidator : AbstractValidator<Student>
{
    public StudentValidator()
    {
        // Reusing the validation rules from UserValidator for User properties
        Include(new UserValidator());

        // Validating Age (must be between 16 and 120)
        RuleFor(student => student.Age)
            .InclusiveBetween(16, 120).WithMessage("Age must be between 16 and 120.");

        // Validating EnrollmentDate (must be in the past or today)
        RuleFor(student => student.EnrollmentDate)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Enrollment date cannot be in the future.");

        // Validating GraduationDate (must be greater than or equal to EnrollmentDate, if provided)
        RuleFor(student => student.GraduationDate)
            .GreaterThanOrEqualTo(student => student.EnrollmentDate)
            .WithMessage("Graduation date must be after the enrollment date.");

        // Ensuring that at least one course is enrolled
        //RuleFor(student => student.Courses)
        //    .NotEmpty().WithMessage("At least one course must be enrolled.")
        //    .Must(courses => courses.Count > 0).WithMessage("Student must be enrolled in at least one course.");
    }
}
