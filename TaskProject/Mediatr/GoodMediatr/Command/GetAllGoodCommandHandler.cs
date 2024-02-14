using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Command;

public class GetAllGoodCommandHandler : IRequestHandler<GetAllGoodCommand, Result<List<Good>>>
{
    private readonly IGoodAdd _category;
    public GetAllGoodCommandHandler(IGoodAdd todoitems)
    {
        _category = todoitems;
    }
    public async Task<Result<List<Good>>> Handle(GetAllGoodCommand request, CancellationToken cancellationToken)
    {
        var item = await _category.GetGoods();
        return Result.Success(new List<Good>());
    }
}
