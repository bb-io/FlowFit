using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Responses.Document;
using Apps.FlowFit.Polling.Models;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Common.Polling;

namespace Apps.FlowFit.Polling;

[PollingEventList]
public class PollingList(InvocationContext invocationContext) : FlowFitInvocable(invocationContext)
{
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

        await WebhookLogger.LogAsync(new
        {
            message = "Polling for new project documents",
            request.Memory.TaskIds,
            allDocuments = documents,
            newDocuments
        });

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