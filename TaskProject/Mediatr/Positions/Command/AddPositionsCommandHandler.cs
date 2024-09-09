using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Positions.Command;

public class AddPositionsCommandHandler : IRequestHandler<AddPositionsCommand, Result>
{
    private readonly IPositionService _positionService;

    public AddPositionsCommandHandler(IPositionService positionService) 
        => _positionService = positionService;

    public async Task<Result> Handle(AddPositionsCommand request, CancellationToken cancellationToken)
    {
        await _positionService.AddPositions();

        return Result.Success();
    }
}