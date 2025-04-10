using FluentValidation;
using TaskProject.Mediatr.Good.Command;

namespace TaskProject.Mediatr.Good.Validators
{
    public class AddGoodCommandValidator : AbstractValidator<AddGoodCommand>
    {
        public AddGoodCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Good name is required.")
                .Length(3, 100).WithMessage("Good name must be between 3 and 100 characters.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description is required.")
                .Length(10, 500).WithMessage("Description must be between 10 and 500 characters.");

            RuleFor(x => x.CategoryFields)
                .NotEmpty().WithMessage("Category fields are required.");

            RuleFor(x => x.CategoryId)
                .GreaterThan(0).WithMessage("CategoryId must be greater than 0.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Price must be greater than 0.");
        }
    }
}
