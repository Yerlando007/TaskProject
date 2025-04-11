namespace DataManager.Response;

public class HttpBinResponse
{
    public Dictionary<string, string>? Args { get; set; }
    public Dictionary<string, string>? Headers { get; set; }
    public string? Origin { get; set; }
    public string? Url { get; set; }
}
