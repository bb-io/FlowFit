using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class WorkTypeActions : FlowFitInvocable
{
    public WorkTypeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all work types", Description = "Returns all the work types that have been created.")]
    public async Task GetWorkTypes()
    {
        var request = new FlowFitRequest("/api/v1/WorkTypes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<WorkTypeResult>>(request);
    }

    [Action("Create a new work type", Description = "Creates a new work type and returns the work type result.")]
    public async Task PostWorkType()
    {
        var request = new FlowFitRequest("/api/v1/WorkTypes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<WorkTypeResult>(request);
    }

    [Action("Get work type", Description = "Returns all the details of a work type.")]
    public async Task GetWorkType()
    {
        var request = new FlowFitRequest("/api/v1/WorkTypes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<WorkTypeResult>(request);
    }

    [Action("Update a work type", Description = "Updates an existing work type and returns the work type result")]
    public async Task PutWorkType()
    {
        var request = new FlowFitRequest("/api/v1/WorkTypes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<WorkTypeResult>(request);
    }

    [Action("Delete a WorkType", Description = "Deletes the given work type. Will also delete all related entities.")]
    public async Task DeleteWorkType()
    {
        var request = new FlowFitRequest("/api/v1/WorkTypes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}