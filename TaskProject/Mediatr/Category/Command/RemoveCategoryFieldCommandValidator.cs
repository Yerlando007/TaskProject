using FluentValidation;
using TaskProject.Mediatr.Category.Command;

namespace TaskProject.Mediatr.Category.Validators
{
    public class RemoveCategoryFieldCommandValidator : AbstractValidator<RemoveCategoryFieldCommand>
    {
        public RemoveCategoryFieldCommandValidator()
        {
            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("CategoryId must be greater than 0.");

            RuleFor(x => x.Field)
                .NotNull().WithMessage("Fields cannot be null.")
                .NotEmpty().WithMessage("At least one field is required.")
                .ForEach(f => f.GreaterThan(0).WithMessage("Each field id must be greater than 0."));
        }
    }
}
