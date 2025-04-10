using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Category.Command;

public class AddCategoryCommandHandler : IRequestHandler<AddCategoryCommand, Result>
{
    private readonly ICategoryAdd _category;

    public AddCategoryCommandHandler(ICategoryAdd todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result> Handle(AddCategoryCommand request, CancellationToken cancellationToken)
    {
        await _category.AddCategory(request);

        return Result.Success();
    }
}