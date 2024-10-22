using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using RestSharp;

namespace Apps.FlowFit;

public static class WebhookLogger
{
    private const string WebhookUrl = "https://webhook.site/15b2f95d-9f2d-4fc2-a0e7-79eb1f7914fa";

    public static async Task LogAsync<T>(T data)
        where T : class
    {
        var restClient = new RestClient(WebhookUrl);
        var request = new RestRequest(string.Empty, Method.Post)
            .WithJsonBody(data);
        
        await restClient.ExecuteAsync(request);
    }
    
    public static async Task LogAsync(Exception exception)
    {
        var restClient = new RestClient(WebhookUrl);
        var request = new RestRequest(string.Empty, Method.Post)
            .WithJsonBody(new { exception.Message, exception.StackTrace, exeptionType = exception.GetType().Name });
        
        await restClient.ExecuteAsync(request);
    }
}