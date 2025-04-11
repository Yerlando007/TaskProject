using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Good.Command;

public class AddGoodCommandHandler : IRequestHandler<AddGoodCommand, Result>
{
    private readonly IGood _good;
    public AddGoodCommandHandler(IGood todoitems)
    {
        _good = todoitems;
    }
    public async Task<Result> Handle(AddGoodCommand request, CancellationToken cancellationToken)
        => await _good.AddGoodItem(request);
}