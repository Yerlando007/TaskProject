using FluentValidation;

namespace TaskProject.Mediatr.Category.Command
{
    public class AddCategoryCommandValidator : AbstractValidator<AddCategoryCommand>
    {
        public AddCategoryCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Category name is required.")
                .Length(3, 100).WithMessage("Category name must be between 3 and 100 characters.");

            RuleFor(x => x.Field)
                .NotNull().WithMessage("Fields cannot be null.")
                .NotEmpty().WithMessage("At least one field is required.")
                .ForEach(f => f.NotEmpty().WithMessage("Field name cannot be empty."));
        }
    }
}