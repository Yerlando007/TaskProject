using DataManager.Requests;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Car.Command;

public class AddCarToWorkerCommand : IRequest<Result>
{
    public AddCarToWorkerCommand(AddCarToWorker value)
    {
        WhoAddedId = value.WhoAddedId;
        CarNumberOfWorker = value.CarNumberOfWorker;
        WorkerId = value.WorkerId;
    }

    public int WhoAddedId { get; set; }
    public string CarNumberOfWorker { get; set; } = null!;
    public int WorkerId { get; set; }
}