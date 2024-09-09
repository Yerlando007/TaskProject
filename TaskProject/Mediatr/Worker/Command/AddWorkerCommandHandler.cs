using DataManager.EF;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Worker.Command;

public class AddWorkerCommandHandler : IRequestHandler<AddWorkerCommand, Result>
{
    private readonly IWorkerService _workerService;

    public AddWorkerCommandHandler(IWorkerService workerService) 
        => _workerService = workerService;

    public async Task<Result> Handle(AddWorkerCommand request, CancellationToken cancellationToken)
    {
        var item = await _workerService.AddWorker(request);

        return Result.Success(item);
    }
}