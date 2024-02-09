using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class TargetAudienceActions : FlowFitInvocable
{
    public TargetAudienceActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the target audiences", Description = "Returns a list of all the target audiences that have been created.")]
    public async Task GetTargetAudiences()
    {
        var request = new FlowFitRequest("/api/v1/TargetAudiences", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TargetAudienceResult>>(request);
    }

    [Action("Creates a new target audience", Description = "Creates a new target audience and returns a target audience result.")]
    public async Task PostTargetAudience()
    {
        var request = new FlowFitRequest("/api/v1/TargetAudiences", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<TargetAudienceResult>(request);
    }

    [Action("Returns a target audience", Description = "Returns all the details of a target audience.")]
    public async Task GetTargetAudience()
    {
        var request = new FlowFitRequest("/api/v1/TargetAudiences/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TargetAudienceResult>(request);
    }

    [Action("Update a Target Audience", Description = "Updates an existing target audience and returns the target audience result.")]
    public async Task PutTargetAudience()
    {
        var request = new FlowFitRequest("/api/v1/TargetAudiences/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<TargetAudienceResult>(request);
    }

    [Action("Delete a Target Audience", Description = "Deletes the given target audience. Will also delete all related entities.")]
    public async Task DeleteTargetAudience()
    {
        var request = new FlowFitRequest("/api/v1/TargetAudiences/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}