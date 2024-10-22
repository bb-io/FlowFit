using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Requests.Project;
using Apps.FlowFit.Models.Responses.Document;
using Apps.FlowFit.Models.Responses.Project;
using Apps.FlowFit.Polling.Models;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Polling;

namespace Apps.FlowFit.Polling;

[PollingEventList]
public class PollingList(InvocationContext invocationContext) : FlowFitInvocable(invocationContext)
{
    [PollingEvent("On project status changed",
        Description = "Returns project status that was changed after the last polling time")]
    public async Task<PollingEventResponse<ProjectStatusMemory, ProjectsResponse>> OnProjectStatusChanged(
        PollingEventRequest<ProjectStatusMemory> request,
        [PollingEventParameter] ProjectOptionalIdentifer projectIdentifier,
        [PollingEventParameter] ProjectStatusRequest statusRequest)
    {
        var apiRequest = new FlowFitRequest($"/api/v1/Projects");
        var projects = await Client.ExecuteWithErrorHandling<List<ProjectResponse>>(apiRequest);

        if (request.Memory is null)
        {
            return new PollingEventResponse<ProjectStatusMemory, ProjectsResponse>
            {
                FlyBird = false,
                Memory = new ProjectStatusMemory { Entities = projects.Select(x => new ProjectMemoryEntity()
                {
                    ProjectId = x.Id,
                    Status = x.Status.Id
                }).ToList()},
                Result = null
            };
        }
        
        var previousStatuses = request.Memory.Entities.ToDictionary(e => e.ProjectId, e => e.Status);

        var newProjects = projects
            .Where(project =>
                previousStatuses.TryGetValue(project.Id, out var oldStatus) && oldStatus != project.Status.Id &&
                project.Status.Id == statusRequest.StatusId &&
                (projectIdentifier.ProjectId == null || project.Id == projectIdentifier.ProjectId))
            .ToList();

        request.Memory.Entities = projects.Select(x => new ProjectMemoryEntity
        {
            ProjectId = x.Id,
            Status = x.Status.Id
        }).ToList();
        
        return new PollingEventResponse<ProjectStatusMemory, ProjectsResponse>
        {
            FlyBird = newProjects.Count > 0,
            Memory = new ProjectStatusMemory { Entities = projects.Select(x => new ProjectMemoryEntity()
            {
                ProjectId = x.Id,
                Status = x.Status.Id
            }).ToList()},
            Result = new ProjectsResponse
            {
                Projects = newProjects
            }
        };
    }
    
    [PollingEvent("On project documents delivered",
        Description = "Returns project documents that were delivered after the last polling time")]
    public async Task<PollingEventResponse<DocumentMemory, ProjectDeliveredResponse>>
        OnProjectFilesDelivered(PollingEventRequest<DocumentMemory> request,
            [PollingEventParameter] ProjectIdentifier projectIdentifier)
    {
        var apiRequest =
            new FlowFitRequest($"/api/v1/ProjectDocuments/{projectIdentifier.ProjectId}/AllDeliverableDocuments");
        var documents = await Client.ExecuteWithErrorHandling<List<DeliveredProjectDocumentResponse>>(apiRequest);

        if (request.Memory is null)
        {
            return new PollingEventResponse<DocumentMemory, ProjectDeliveredResponse>
            {
                FlyBird = false,
                Memory = new DocumentMemory { TaskIds = documents.Select(x => x.TaskId).ToList() },
                Result = null
            };
        }
        
        var newDocuments = documents
            .Where(x => !request.Memory.TaskIds.Contains(x.TaskId))
            .ToList();

        return new PollingEventResponse<DocumentMemory, ProjectDeliveredResponse>
        {
            FlyBird = newDocuments.Count > 0,
            Memory = new DocumentMemory { TaskIds = documents.Select(x => x.TaskId).ToList() },
            Result = new ProjectDeliveredResponse
            {
                Documents = newDocuments,
                ProjectId = projectIdentifier.ProjectId
            }
        };
    }
}