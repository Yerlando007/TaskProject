using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;
using TaskProject.Mediatr.Car.Command;

namespace TaskProject.Mediatr.Worker.Command;

public class AddCarToWorkerCommandHandler : IRequestHandler<AddCarToWorkerCommand, Result>
{
    private readonly ICarService _carService;

    public AddCarToWorkerCommandHandler(ICarService carService) 
        => _carService = carService;

    public async Task<Result> Handle(AddCarToWorkerCommand request, CancellationToken cancellationToken)
    {
        var item = await _carService.AddCarToWorker(request);

        return Result.Success(item);
    }
}