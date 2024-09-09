using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Worker.Command;

public class DeleteWorkerCommandHandler : IRequestHandler<DeleteWorkerCommand, Result>
{
    private readonly IWorkerService _workerService;

    public DeleteWorkerCommandHandler(IWorkerService workerService) 
        => _workerService = workerService;

    public async Task<Result> Handle(DeleteWorkerCommand request, CancellationToken cancellationToken)
    {
        var item = await _workerService.DeleteWorker(request);
        return Result.Success(item);
    }
}