using RestSharp;

namespace Apps.FlowFit.Api;

public class FlowFitRequest(string endpoint, Method method = Method.Get) : RestRequest(endpoint, method);
