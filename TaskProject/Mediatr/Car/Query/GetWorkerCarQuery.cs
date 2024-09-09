using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Car.Query;

public class GetWorkerCarQuery : IRequest<Result<CarNumber>>
{
    public GetWorkerCarQuery(int workerId)
    {
        WorkerId = workerId;
    }

    public int WorkerId { get; set; }
}