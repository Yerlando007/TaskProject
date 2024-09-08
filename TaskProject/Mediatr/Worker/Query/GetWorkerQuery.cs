using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Worker.Query;

public class GetWorkerQuery : IRequest<Result<DataManager.EF.Worker>>
{
    public GetWorkerQuery(int workerId)
    {
        WorkerId = workerId;
    }

    public int WorkerId { get; set; }
}