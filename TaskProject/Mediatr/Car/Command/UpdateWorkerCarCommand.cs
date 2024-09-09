using DataManager.Requests;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Worker.Command;

public class UpdateWorkerCarCommand : IRequest<Result>
{
    public UpdateWorkerCarCommand(UpdateCarOfWorker value)
    {
        WorkerId = value.WorkerId;
        CarNumberOfWorker = value.CarNumberOfWorker;
    }
    public int WorkerId { get; set; }
    public string CarNumberOfWorker { get; set; } = null!;
}