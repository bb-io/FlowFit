using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Dtos.Project;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Requests.Project;
using Apps.FlowFit.Models.Responses;
using Apps.FlowFit.Models.Responses.Project;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using RestSharp;

namespace Apps.FlowFit.Actions;

[ActionList]
public class ProjectActions : FlowFitInvocable
{
    private readonly IFileManagementClient _fileManagementClient;
    
    public ProjectActions(InvocationContext invocationContext, IFileManagementClient fileManagementClient) 
        : base(invocationContext)
    {
        _fileManagementClient = fileManagementClient;
    }

    #region Get

    [Action("Get project details", Description = "Get information about a project.")]
    public async Task<ProjectResponse> GetProject([ActionParameter] ProjectIdentifier projectIdentifier)
    {
        var request = new FlowFitRequest($"/api/v1/Projects/{projectIdentifier.ProjectId}");
        var response = await Client.ExecuteWithErrorHandling<ProjectResponse>(request);
        return response;
    }

    #endregion

    #region Post

    [Action("Create new project", Description = "Create a new project.")]
    public async Task<ProjectResponse> PostProject([ActionParameter] ClientIdentifier clientIdentifier, 
        [ActionParameter] CreateProjectRequest input)
    {
        var request = new FlowFitRequest("/api/v1/Projects", Method.Post)
            .WithJsonBody(new ProjectDto(input, clientIdentifier, _fileManagementClient));
        var response = await Client.ExecuteWithErrorHandling<ProjectResponse>(request);
        return response;
    }

    #endregion

    #region Delete

    [Action("Delete project", Description = "Deletes the specified project, along with all associated entities.")]
    public async Task DeleteProject([ActionParameter] ProjectIdentifier projectIdentifier)
    {
        var request = new FlowFitRequest($"/api/v1/Projects/{projectIdentifier.ProjectId}", Method.Delete);
        await Client.ExecuteWithErrorHandling(request);
    }

    #endregion
    
    #region Generated
    
    [Action("Get all projects", Description = "Returns a list of all the projects that have been created.")]
    public async Task GetProjects()
    {
        var request = new FlowFitRequest("/api/v1/Projects", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectListResult>>(request);
    }

    [Action("Get projects by filters", Description = "Returns a list of all the projects with the filters.")]
    public async Task GetByFilters()
    {
        var request = new FlowFitRequest("/api/v1/Projects/GetByFilters", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectResponse>>(request);
    }

    [Action("Get the active projects", Description = "Returns a list of all the active projects. Filters can be used to refine the search.")]
    public async Task GetActiveProjects()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{filters}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectActiveListResult>>(request);
    }

    [Action("Update a project", Description = "Updates an existing project and returns the project result.")]
    public async Task PutProject()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProjectResponse>(request);
    }

    [Action("Get project status", Description = "Returns the status of the project.")]
    public async Task GetProjectStatusByProjectId()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{projectId}/status", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectStatusDTO>(request);
    }

    [Action("Update the project status", Description = "Update the status of the given project, and return the new status.")]
    public async Task PutProjectStatus()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{projectId}/status", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling<ProjectStatusDTO>(request);
    }

    [Action("Update the project manager", Description = "Assign a project to a project manager.")]
    public async Task AssignProjectManager()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{projectId}/assignprojectmanager", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling(request);
    }

    [Action("Change a project deadline", Description = "Change a given project's deadline")]
    public async Task ChangeProjectDeadline()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{projectId}/changeprojectdeadline", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling(request);
    }

    [Action("Update the project languages", Description = "Update the source and/or target languages of the given project")]
    public async Task UpdateProjectLangagues()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{projectId}/{updateCatTools}/updateprojectlanguages", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling(request);
    }

    [Action("Update project partially by field", Description = "Updates specific fields in a project based on the given list of fields. Available fields are defined in the ProjectPutDTO, from the main Projects PUT operation.")]
    public async Task PartialUpdate()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{projectId}/partialupdate", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling(request);
    }

    [Action("Reopen a project", Description = "Reopen a project")]
    public async Task ReopenProject()
    {
        var request = new FlowFitRequest("/api/v1/Projects/{projectId}/reopen", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling(request);
    }

    [Action("Search a project by filters", Description = "Returns a list of all the projects with the filters.")]
    public async Task Search()
    {
        var request = new FlowFitRequest("/api/v1/Projects/Search", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectSearchListResult>>(request);
    }
    
    #endregion
}