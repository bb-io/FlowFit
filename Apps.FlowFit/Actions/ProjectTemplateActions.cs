using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProjectTemplateActions : FlowFitInvocable
{
    public ProjectTemplateActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all of the project templates.", Description = "Returns a list of all the project templates that have been created.")]
    public async Task GetProjectTemplates()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTemplates", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectTemplateResult>>(request);
    }

    [Action("Create a new project template", Description = "Creates a new project template and returns the project template result.")]
    public async Task PostProjectTemplate()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTemplates", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProjectTemplateResult>(request);
    }

    [Action("Get project template", Description = "Returns all the details of a project template.")]
    public async Task GetProjectTemplate()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTemplates/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectTemplateResult>(request);
    }

    [Action("Update a project template", Description = "Updates an existing project template and returns the project template result.")]
    public async Task PutProjectTemplate()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTemplates/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProjectTemplateResult>(request);
    }

    [Action("Delete a project template", Description = "Deletes the given project template. Will also delete all related entities.")]
    public async Task DeleteProjectTemplate()
    {
        var request = new FlowFitRequest("/api/v1/ProjectTemplates/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}