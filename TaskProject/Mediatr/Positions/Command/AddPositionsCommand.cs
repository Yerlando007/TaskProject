using DataManager.Requests;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Positions.Command;

public class AddPositionsCommand : IRequest<Result>
{
    public AddPositionsCommand() { }
}