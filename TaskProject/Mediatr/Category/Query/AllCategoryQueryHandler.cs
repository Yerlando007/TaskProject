using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Category.Query;

public class AllCategoryQueryHandler : IRequestHandler<AllCategoryQuery, Result<List<Categories>>>
{
    private readonly ICategory _category;

    public AllCategoryQueryHandler(ICategory todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result<List<Categories>>> Handle(AllCategoryQuery request, CancellationToken cancellationToken)
        => await _category.GetFieldsCategory();
}