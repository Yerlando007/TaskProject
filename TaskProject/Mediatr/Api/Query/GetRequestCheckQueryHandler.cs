using DataManager.Response;
using KDS.Primitives.FluentResult;
using MediatR;
using TaskProject.Interfaces;

namespace TaskProject.Mediatr.Api.Query;

public class GetRequestCheckQueryHandler : IRequestHandler<GetRequestCheckQuery, Result<HttpBinResponse>>
{
    private readonly IApiClient _apiClient;

    public GetRequestCheckQueryHandler(IApiClient todoitems)
    {
        _apiClient = todoitems;
    }

    public async Task<Result<HttpBinResponse>> Handle(GetRequestCheckQuery request, CancellationToken cancellationToken)
    {
        var result = await _apiClient.GetAsync();

        return result;
    }
}