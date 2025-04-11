using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Good.Query;

public class AllGoodQueryHandler : IRequestHandler<AllGoodQuery, Result<List<Goods>>>
{
    private readonly IGood _category;
    public AllGoodQueryHandler(IGood todoitems)
    {
        _category = todoitems;
    }
    public async Task<Result<List<Goods>>> Handle(AllGoodQuery request, CancellationToken cancellationToken)
        => await _category.GetGoods();
}