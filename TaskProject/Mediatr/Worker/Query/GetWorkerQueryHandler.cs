using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Worker.Query;

public class GetWorkerQueryHandler : IRequestHandler<GetWorkerQuery, Result<DataManager.EF.Worker>>
{
    private readonly IWorkerService _category;

    public GetWorkerQueryHandler(IWorkerService todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result<DataManager.EF.Worker>> Handle(GetWorkerQuery request, CancellationToken cancellationToken)
    {
        var item = await _category.GetWorker(request.WorkerId);
        return Result.Success(item);
    }
}