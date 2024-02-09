using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class PositionActions : FlowFitInvocable
{
    public PositionActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the positions.", Description = "Returns a list of all the positions that have been created.")]
    public async Task GetPositions()
    {
        var request = new FlowFitRequest("/api/v1/Positions", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<PositionResult>>(request);
    }

    [Action("Create a new position", Description = "Creates a new position and returns the position result.")]
    public async Task PostPosition()
    {
        var request = new FlowFitRequest("/api/v1/Positions", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<PositionResult>(request);
    }

    [Action("Get a position", Description = "Returns all the details of a position.")]
    public async Task GetPosition()
    {
        var request = new FlowFitRequest("/api/v1/Positions/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<PositionResult>(request);
    }

    [Action("Update a position", Description = "Updates an existing position and returns the position result.")]
    public async Task PutPosition()
    {
        var request = new FlowFitRequest("/api/v1/Positions/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<PositionResult>(request);
    }

    [Action("Delete a position", Description = "Deletes the given position. Will also delete all related entities.")]
    public async Task DeletePosition()
    {
        var request = new FlowFitRequest("/api/v1/Positions/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}