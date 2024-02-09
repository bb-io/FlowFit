using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class WorkCodeActions : FlowFitInvocable
{
    public WorkCodeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get a list of work codes. Filters can be used to refine the search.", Description = "Get a list of work codes. Filters can be used to refine the search.")]
    public async Task GetWorkCodes()
    {
        var request = new FlowFitRequest("/api/v1/WorkCodes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<WorkCodeResult>>(request);
    }

    [Action("Create a new work code", Description = "Creates a new work code and returns the work code result.")]
    public async Task PostWorkCode()
    {
        var request = new FlowFitRequest("/api/v1/WorkCodes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<WorkCodeResult>(request);
    }

    [Action("Get a work code", Description = "Returns all the details of a work code.")]
    public async Task GetWorkCode()
    {
        var request = new FlowFitRequest("/api/v1/WorkCodes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<WorkCodeResult>(request);
    }

    [Action("Updates a work code", Description = "Updates an existing work code and returns the work code result.")]
    public async Task PutWorkCode()
    {
        var request = new FlowFitRequest("/api/v1/WorkCodes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<WorkCodeResult>(request);
    }

    [Action("Deletes a work code", Description = "Deletes the given work code. Will also delete all related entities.")]
    public async Task DeleteWorkCode()
    {
        var request = new FlowFitRequest("/api/v1/WorkCodes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}