using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Category.Command;

public class AddCategoryFieldCommandHandler : IRequestHandler<AddCategoryFieldCommand, Result>
{
    private readonly ICategory _category;

    public AddCategoryFieldCommandHandler(ICategory todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result> Handle(AddCategoryFieldCommand request, CancellationToken cancellationToken)
        => await _category.AddFieldCategory(request);
}