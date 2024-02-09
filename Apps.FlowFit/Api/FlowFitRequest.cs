using RestSharp;

namespace Apps.FlowFit.Api;

public class FlowFitRequest : RestRequest
{
    public FlowFitRequest(string endpoint, Method method = Method.Get) : base(endpoint, method)
    {
    }
}
