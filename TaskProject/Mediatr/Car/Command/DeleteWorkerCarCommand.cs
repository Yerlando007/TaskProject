using DataManager.EF;
using DataManager.Requests;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Worker.Command;

public class DeleteWorkerCarCommand : IRequest<Result>
{
    public DeleteWorkerCarCommand(DeleteCarOfWorker value)
    {
        Id = value.CarId;
    }

    public int Id { get; set; }
}