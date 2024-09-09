using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Worker.Command;

public class DeleteWorkerCarCommandHandler : IRequestHandler<DeleteWorkerCarCommand, Result>
{
    private readonly ICarService _carService;

    public DeleteWorkerCarCommandHandler(ICarService carService) 
        => _carService = carService;

    public async Task<Result> Handle(DeleteWorkerCarCommand request, CancellationToken cancellationToken)
    {
        var item = await _carService.DeleteCarOfWorker(request);
        return Result.Success(item);
    }
}