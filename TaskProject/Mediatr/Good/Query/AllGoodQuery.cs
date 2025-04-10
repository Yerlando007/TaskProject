using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Good.Query;

public class AllGoodQuery : IRequest<Result<List<Goods>>>
{
    public AllGoodQuery() {}
}