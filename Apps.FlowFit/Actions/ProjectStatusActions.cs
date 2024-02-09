using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProjectStatusActions : FlowFitInvocable
{
    public ProjectStatusActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the project status", Description = "Returns a list of all the project status that have been created.")]
    public async Task GetProjectStatus()
    {
        var request = new FlowFitRequest("/api/v1/ProjectStatus", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectStatusResult>>(request);
    }

    [Action("Get a project status", Description = "Returns all the details of a project status.")]
    public async Task GetProjectStatusById()
    {
        var request = new FlowFitRequest("/api/v1/ProjectStatus/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectStatusResult>(request);
    }
}