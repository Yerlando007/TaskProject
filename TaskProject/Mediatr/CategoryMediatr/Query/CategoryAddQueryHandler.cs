using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.CategoryMediatr.Query;

public class CategoryAddQueryHandler : IRequestHandler<CategoryAddQuery, Result<bool>>
{
    private readonly ICategoryAdd _category;

    public CategoryAddQueryHandler(ICategoryAdd todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result<bool>> Handle(CategoryAddQuery request, CancellationToken cancellationToken)
    {
        var item = await _category.AddCategory(request);
        return Result.Success(item);
    }
}