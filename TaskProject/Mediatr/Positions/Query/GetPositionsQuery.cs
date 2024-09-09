using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Positions.Query;

public class GetPositionsQuery : IRequest<Result<List<Position>>>
{
    public GetPositionsQuery() { }
}