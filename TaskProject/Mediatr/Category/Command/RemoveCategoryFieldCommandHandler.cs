using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Category.Command;

public class RemoveCategoryFieldCommandHandler : IRequestHandler<RemoveCategoryFieldCommand, Result>
{
    private readonly ICategoryAdd _category;

    public RemoveCategoryFieldCommandHandler(ICategoryAdd todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result> Handle(RemoveCategoryFieldCommand request, CancellationToken cancellationToken)
        => await _category.RemoveFieldCategory(request);
}