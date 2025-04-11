using DataManager.Response;
using KDS.Primitives.FluentResult;
using MediatR;

namespace TaskProject.Mediatr.Api.Query;

public class GetRequestCheckQuery : IRequest<Result<HttpBinResponse>>
{
    public GetRequestCheckQuery() { }
}