using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Car.Query;

public class GetWorkerCarQueryHandler : IRequestHandler<GetWorkerCarQuery, Result<CarNumber>>
{
    private readonly ICarService _carService;

    public GetWorkerCarQueryHandler(ICarService carService)
        => _carService = carService;

    public async Task<Result<CarNumber>> Handle(GetWorkerCarQuery request, CancellationToken cancellationToken)
    {
        var item = await _carService.GetWorkerCar(request.WorkerId);
        return Result.Success(item);
    }
}