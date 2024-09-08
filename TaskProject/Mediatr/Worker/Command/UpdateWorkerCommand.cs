using DataManager.EF;
using DataManager.Requests;
using KDS.Primitives.FluentResult;
using MediatR;
using Newtonsoft.Json.Linq;

namespace TaskProject.Mediatr.Worker.Command;

public class UpdateWorkerCommand : IRequest<Result>
{
    public UpdateWorkerCommand(UpdateWorker value)
    {
        WorkerId = value.WorkerId;
        Fio = value.FIO;
    }
    public int WorkerId { get; set; }
    public string Fio { get; set; } = string.Empty;
}