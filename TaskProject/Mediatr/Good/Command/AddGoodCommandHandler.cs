using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Good.Command;

public class AddGoodCommandHandler : IRequestHandler<AddGoodCommand, Result>
{
    private readonly IGoodAdd _good;
    public AddGoodCommandHandler(IGoodAdd todoitems)
    {
        _good = todoitems;
    }
    public async Task<Result> Handle(AddGoodCommand request, CancellationToken cancellationToken)
        => await _good.AddGoodItem(request);
}