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
    public async Task<PollingEventResponse<FilesMemory, ProjectDeliveredResponse>>
        OnProjectFilesDelivered(PollingEventRequest<FilesMemory> request,
            [PollingEventParameter] ProjectIdentifier projectIdentifier)
    {
        var apiRequest =
            new FlowFitRequest($"/api/v1/ProjectDocuments/{projectIdentifier.ProjectId}/AllDeliverableDocuments");
        var documents = await Client.ExecuteWithErrorHandling<List<DeliveredProjectDocumentResponse>>(apiRequest);

        if (request.Memory is null)
        {
            return new PollingEventResponse<FilesMemory, ProjectDeliveredResponse>
            {
                FlyBird = false,
                Memory = new FilesMemory { LastPollingTime = DateTime.UtcNow },
                Result = null
            };
        }
        
        var newDocuments = documents
            .Where(x => x.ModificationDate.ToUniversalTime() > request.Memory.LastPollingTime.ToUniversalTime()).ToList();

        await WebhookLogger.LogAsync(new
        {
            message = "Polling for new project documents",
            request.Memory.LastPollingTime,
            allDocuments = documents,
            newDocuments
        });

        return new PollingEventResponse<FilesMemory, ProjectDeliveredResponse>
        {
            FlyBird = newDocuments.Count > 0,
            Memory = new FilesMemory { LastPollingTime = DateTime.UtcNow },
            Result = new ProjectDeliveredResponse
            {
                Documents = newDocuments,
                ProjectId = projectIdentifier.ProjectId
            }
        };
    }
}