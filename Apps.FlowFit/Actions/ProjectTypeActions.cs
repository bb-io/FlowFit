using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProjectTypeActions : FlowFitInvocable
{
    public ProjectTypeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the project types", Description = "Returns a lit of all the project types that have been created.")]
    public async Task GetProjectTypes()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTypes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectTypeResult>>(request);
    }

    [Action("Create a new project type", Description = "Creates a new project type and returns the project type result.")]
    public async Task PostProjectType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTypes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProjectTypeResult>(request);
    }

    [Action("Get a project type", Description = "Returns all the details of a project type.")]
    public async Task GetProjectType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTypes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectTypeResult>(request);
    }

    [Action("Update a project type", Description = "Updates an existing project type and returns the project type result.")]
    public async Task PutProjectType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTypes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProjectTypeResult>(request);
    }

    [Action("Delete a project type", Description = "Deletes the given project type. Will also delete all related entities.")]
    public async Task DeleteProjectType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTypes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}