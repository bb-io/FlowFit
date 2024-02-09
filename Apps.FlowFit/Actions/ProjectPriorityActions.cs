using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProjectPriorityActions : FlowFitInvocable
{
    public ProjectPriorityActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the project priorities", Description = "Returns a list of all the project priorities that have been created.")]
    public async Task GetProjectPriorities()
    {
        var request = new FlowFitRequest("/api/v1/ProjectPriorities", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectPriorityResult>>(request);
    }

    [Action("Create a project priority", Description = "Creates a new project priority and returns the project priority result.")]
    public async Task PostProjectPriority()
    {
        var request = new FlowFitRequest("/api/v1/ProjectPriorities", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProjectPriorityResult>(request);
    }

    [Action("Get project priority", Description = "Returns all the details of a project priority.")]
    public async Task GetProjectPriority()
    {
        var request = new FlowFitRequest("/api/v1/ProjectPriorities/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectPriorityResult>(request);
    }

    [Action("Update a project priority", Description = "Updates an existing project priority and returns the project priority result.")]
    public async Task PutProjectPriority()
    {
        var request = new FlowFitRequest("/api/v1/ProjectPriorities/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProjectPriorityResult>(request);
    }

    [Action("Delete a project priority", Description = "Deletes the given project priority. Will also delete all related entities.")]
    public async Task DeleteProjectPriority()
    {
        var request = new FlowFitRequest("/api/v1/ProjectPriorities/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}