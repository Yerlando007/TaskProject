using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Worker.Command;

public class UpdateWorkerCarCommandHandler : IRequestHandler<UpdateWorkerCarCommand, Result>
{
    private readonly ICarService _carService;

    public UpdateWorkerCarCommandHandler(ICarService carService) 
        => _carService = carService;

    public async Task<Result> Handle(UpdateWorkerCarCommand request, CancellationToken cancellationToken)
    {
        var item = await _carService.UpdateCarOfWorker(request);
        return Result.Success(item);
    }
}