using FluentValidation;
using TaskProject.Mediatr.Category.Command;

namespace TaskProject.Mediatr.Category.Validators
{
    public class AddCategoryFieldCommandValidator : AbstractValidator<AddCategoryFieldCommand>
    {
        public AddCategoryFieldCommandValidator()
        {
            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("CategoryId must be greater than 0.");

            RuleFor(x => x.Field)
                .NotNull().WithMessage("Fields cannot be null.")
                .NotEmpty().WithMessage("At least one field is required.")
                .ForEach(f => f.NotEmpty().WithMessage("Field name cannot be empty."));
        }
    }
}