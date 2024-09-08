using DataManager.Requests;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Worker.Command;

public class AddWorkerCommand : IRequest<Result>
{
    public AddWorkerCommand(AddWorker value)
    {
        FIO = value.FIO;
        Position = value.Position;
    }

    public string FIO { get; set; } = null!;
    public int Position { get; set; }
}