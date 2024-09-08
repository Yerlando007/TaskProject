using DataManager.EF;
using DataManager.Requests;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Worker.Command;

public class DeleteWorkerCommand : IRequest<Result>
{
    public DeleteWorkerCommand(DeleteWorker value)
    {
        WorkerId = value.WorkerId;
    }

    public int WorkerId { get; set; }
}