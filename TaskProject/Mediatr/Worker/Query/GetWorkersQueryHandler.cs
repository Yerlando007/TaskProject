using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Worker.Query;

public class GetWorkersQueryHandler : IRequestHandler<GetWorkersQuery, Result<List<DataManager.EF.Worker>>>
{
    private readonly IWorkerService _workerService;

    public GetWorkersQueryHandler(IWorkerService workerService) 
        => _workerService = workerService;

    public async Task<Result<List<DataManager.EF.Worker>>> Handle(GetWorkersQuery request, CancellationToken cancellationToken)
    {
        var item = await _workerService.GetWorkers();
        return Result.Success(item);
    }
}