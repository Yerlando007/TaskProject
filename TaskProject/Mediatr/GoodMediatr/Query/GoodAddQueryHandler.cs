using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Query;

public class GoodAddQueryHandler : IRequestHandler<GoodAddQuery, Result<bool>>
{
    private readonly IGoodAdd _good;
    public GoodAddQueryHandler(IGoodAdd todoitems)
    {
        _good = todoitems;
    }
    public async Task<Result<bool>> Handle(GoodAddQuery request, CancellationToken cancellationToken)
    {
        var item = await _good.AddGoodItem(request);
        return Result.Success(item);
    }
}
