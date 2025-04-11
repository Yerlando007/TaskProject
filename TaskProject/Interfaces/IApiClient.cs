using DataManager.Response;
using KDS.Primitives.FluentResult;

namespace TaskProject.Interfaces;

public interface IApiClient
{
    Task<Result<HttpBinResponse>> GetAsync();
}