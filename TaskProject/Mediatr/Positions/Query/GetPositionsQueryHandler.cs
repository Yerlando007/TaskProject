using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Positions.Query;

public class GetPositionsQueryHandler : IRequestHandler<GetPositionsQuery, Result<List<Position>>>
{
    private readonly IPositionService _positionService;

    public GetPositionsQueryHandler(IPositionService positionService) 
        => _positionService = positionService;

    public async Task<Result<List<Position>>> Handle(GetPositionsQuery request, CancellationToken cancellationToken)
    {
        var item = await _positionService.GetPositions();
        return Result.Success(item);
    }
}