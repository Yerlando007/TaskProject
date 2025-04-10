using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Category.Query;

public class AllCategoryQuery : IRequest<Result<List<Categories>>>
{
    public AllCategoryQuery() { }
}