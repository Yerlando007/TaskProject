using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.CategoryMediatr.Query;

public class CategoryRemoveFieldQueryHandler : IRequestHandler<CategoryRemoveFieldQuery, Result<bool>>
{
    private readonly ICategoryAdd _category;
    public CategoryRemoveFieldQueryHandler(ICategoryAdd todoitems)
    {
        _category = todoitems;
    }
    public async Task<Result<bool>> Handle(CategoryRemoveFieldQuery request, CancellationToken cancellationToken)
    {
        var item = await _category.RemoveFieldCategory(request);
        return Result.Success(item);
    }
}
