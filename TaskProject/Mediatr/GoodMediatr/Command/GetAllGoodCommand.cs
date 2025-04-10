using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.GoodMediatr.Command;

public class GetAllGoodCommand : IRequest<Result<List<Good>>>
{
    public GetAllGoodCommand() {}
}