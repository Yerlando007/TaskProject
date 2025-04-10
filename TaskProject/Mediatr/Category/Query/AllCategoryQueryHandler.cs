using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Category.Query;

public class AllCategoryQueryHandler : IRequestHandler<AllCategoryQuery, Result<List<Categories>>>
{
    private readonly ICategoryAdd _category;

    public AllCategoryQueryHandler(ICategoryAdd todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result<List<Categories>>> Handle(AllCategoryQuery request, CancellationToken cancellationToken)
        => await _category.GetFieldsCategory();
}