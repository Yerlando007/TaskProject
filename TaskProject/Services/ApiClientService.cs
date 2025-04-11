using DataManager.Base;
using DataManager.Response;
using KDS.Primitives.FluentResult;
using Newtonsoft.Json;
using System.Diagnostics;
using TaskProject.Extensions;
using TaskProject.Interfaces;

namespace TaskProject.Services;

public class ApiClientService : IApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClientService(HttpClient httpClient)
        => _httpClient = httpClient;

    public async Task<Result<HttpBinResponse>> GetAsync()
    {
        Stopwatch stopwatch = new Stopwatch();
        try
        {
            stopwatch.Start();

            string url = "https://httpbin.org/get";
            Console.WriteLine($"[INFO] Отправка запроса: {url}");

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"[INFO] Ответ: {json}");

            stopwatch.Stop();
            Console.WriteLine($"[INFO] Время выполнения запроса: {stopwatch.ElapsedMilliseconds} мс");

            var httpBinResponse = JsonConvert.DeserializeObject<HttpBinResponse>(json);

            return Result.Success(httpBinResponse!);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"[ERROR] Ошибка HTTP: {ex.Message}");
            return Result.Failure<HttpBinResponse>(CustomError.Create(ErrorCode.NetworkError, ex.Message));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] Неожиданная ошибка: {ex.Message}");
            return Result.Failure<HttpBinResponse>(CustomError.Create(ErrorCode.UnexpectedError, ex.Message));
        }
        finally
        {
            stopwatch.Stop();
            Console.WriteLine($"[INFO] Время выполнения запроса (с учетом ошибок): {stopwatch.ElapsedMilliseconds} мс");
        }
    }
}