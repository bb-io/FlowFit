using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class DelayReasonActions : FlowFitInvocable
{
    public DelayReasonActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the delay reasons", Description = "Returns a list of all the delay reasons that have been created.")]
    public async Task GetDelayReasons()
    {
        var request = new FlowFitRequest("/api/v1/DelayReasons", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<DelayReasonResult>>(request);
    }

    [Action("Create a new delay reason", Description = "Creates a new delay reason and returns the delay reason result.")]
    public async Task PostDelayReason()
    {
        var request = new FlowFitRequest("/api/v1/DelayReasons", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<DelayReasonResult>(request);
    }

    [Action("Get a delay reason", Description = "Returns all the details of a delay reason.")]
    public async Task GetDelayReason()
    {
        var request = new FlowFitRequest("/api/v1/DelayReasons/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<DelayReasonResult>(request);
    }

    [Action("Update a delay reason", Description = "Updates an existing delay reason and returns the delay reason result.")]
    public async Task PutDelayReason()
    {
        var request = new FlowFitRequest("/api/v1/DelayReasons/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<DelayReasonResult>(request);
    }

    [Action("Delete a delay reason", Description = "Deletes the given delay reason.")]
    public async Task DeleteDelayReason()
    {
        var request = new FlowFitRequest("/api/v1/DelayReasons/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling<DelayReasonResult>(request);
    }
}