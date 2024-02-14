using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.CategoryMediatr.Query;

public class CategoryAddFieldQueryHandler : IRequestHandler<CategoryAddFieldQuery, Result<bool>>
{
    private readonly ICategoryAdd _category;

    public CategoryAddFieldQueryHandler(ICategoryAdd todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result<bool>> Handle(CategoryAddFieldQuery request, CancellationToken cancellationToken)
    {
        var item = await _category.AddFieldCategory(request);
        return Result.Success(item);
    }
}