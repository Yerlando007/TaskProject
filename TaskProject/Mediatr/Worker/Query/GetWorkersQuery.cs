using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Worker.Query;

public class GetWorkersQuery : IRequest<Result<List<DataManager.EF.Worker>>>
{
    public GetWorkersQuery() { }
}