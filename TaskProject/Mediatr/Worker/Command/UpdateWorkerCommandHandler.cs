using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Worker.Command;

public class UpdateWorkerCommandHandler : IRequestHandler<UpdateWorkerCommand, Result>
{
    private readonly IWorkerService _category;

    public UpdateWorkerCommandHandler(IWorkerService todoitems)
    {
        _category = todoitems;
    }

    public async Task<Result> Handle(UpdateWorkerCommand request, CancellationToken cancellationToken)
    {
        var item = await _category.UpdateWorker(request);
        return Result.Success(item);
    }
}