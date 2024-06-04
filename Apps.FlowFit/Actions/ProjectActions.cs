using Apps.FlowFit.Api;
using Apps.FlowFit.Extensions;
using Apps.FlowFit.Models.Dtos.Field;
using Apps.FlowFit.Models.Dtos.Project;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Requests.Project;
using Apps.FlowFit.Models.Responses.Project;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using RestSharp;

namespace Apps.FlowFit.Actions;

[ActionList]
public class ProjectActions(InvocationContext invocationContext, IFileManagementClient fileManagementClient)
    : FlowFitInvocable(invocationContext)
{
    #region Get

    [Action("Get project", Description = "Get information about a project.")]
    public async Task<ProjectResponse> GetProject([ActionParameter] ProjectIdentifier projectIdentifier)
    {
        var getProjectRequest = new FlowFitRequest($"/api/v1/Projects/{projectIdentifier.ProjectId}");
        var project = await Client.ExecuteWithErrorHandling<ProjectDto>(getProjectRequest);
        return await ProjectResponse.Create(Client, project);
    }

    #endregion

    #region Post

    [Action("Create project", Description = "Create a new project.")]
    public async Task<ProjectResponse> PostProject([ActionParameter] ClientIdentifier clientIdentifier, 
        [ActionParameter] CreateProjectRequest input)
    {
        var request = new FlowFitRequest("/api/v1/Projects", Method.Post)
            .WithJsonBody(new
            {
                ClientId = clientIdentifier.ClientId.ConvertToInt32(),
                WorkTypeId = input.WorkTypeId.ConvertToInt32(),
                Title = input.Title,
                ProjectRequesterId = input.ProjectRequesterId.ConvertToInt32(),
                TemplateId = input.TemplateId.ConvertToInt32(),
                ClientDepartmentId = input.ClientDepartmentId.ConvertToInt32(),
                SourceLanguageId = input.SourceLanguageId.ConvertToInt32(),
                ManagerId = input.ManagerId.ConvertToInt32(),
                RequestedDeadline = input.RequestedDeadline,
                Detail = input.Details,
                TargetLanguages = input.TargetLanguageIds?.Select(int.Parse),
                SourceFiles = input.SourceFiles?.Select(async file =>
                {
                    var fileStream = await fileManagementClient.DownloadAsync(file);
                    return new
                    {
                        FileName = file.Name,
                        FileContent = await fileStream.ConvertToBase64String()
                    };
                })
            });
        
        var project = await Client.ExecuteWithErrorHandling<ProjectDto>(request);
        return await ProjectResponse.Create(Client, project);
    }

    #endregion
    
    #region Put
    
    [Action("Update project", Description = "Update a project, specifying only the fields that require updating.")]
    public async Task<ProjectResponse> UpdateProject([ActionParameter] ProjectIdentifier projectIdentifier,
        [ActionParameter] UpdateProjectRequest input)
    {
        var getProjectRequest = new FlowFitRequest($"/api/v1/Projects/{projectIdentifier.ProjectId}");
        var project = await Client.ExecuteWithErrorHandling<ProjectDto>(getProjectRequest);

        var updateProjectRequest = new FlowFitRequest($"/api/v1/Projects/{projectIdentifier.ProjectId}", Method.Put)
            .WithJsonBody(new
            {
                ClientId = project.Client.Id.ConvertToInt32(),
                WorkTypeId = (input.WorkTypeId ?? project.Id).ConvertToInt32(),
                Title = input.Title ?? project.Title,
                ProjectRequesterId = project.Requester.Id.ConvertToInt32(),
                TemplateId = (input.TemplateId ?? project.TemplateId).ConvertToInt32(),
                ClientDepartmentId = project.ClientDepartmentId.ConvertToInt32(),
                SourceLanguageId = (input.SourceLanguageId ?? project.SourceLanguage?.Id).ConvertToInt32(),
                ManagerId = (input.ManagerId ?? project.Manager?.Id).ConvertToInt32(),
                Manager2Id = project.Manager2?.Id.ConvertToInt32(),
                Detail = input.Details ?? project.Detail,
                TargetLanguages = (input.TargetLanguageIds ?? project.TargetLanguages?.Select(language => language.Id))
                    ?.Select(int.Parse),
                PrevProjectNumber = project.PrevProjectNumber,
                DomainId = project.DomainId.ConvertToInt32(),
                PriorityId = project.Priority?.Id.ConvertToInt32(),
                ProjectContacts = project.ProjectContacts,
                StatusId = (input.StatusId ?? project.Status.Id).ConvertToInt32(),
                StartDate = project.StartDate,
                DelayReasonId = (input.DelayReasonId ?? project.DelayReasonId).ConvertToInt32(),
                RequestedDeadline = input.RequestedDeadline ?? project.RequestedDeadline,
                NegotiatedDeadline = input.NegotiatedDeadline ?? project.NegotiatedDeadline,
                CompletedDate = input.CompletedDate ?? project.CompletedDate,
                DeliveryDate = input.DeliveryDate ?? project.DeliveryDate,
                DateArchival = input.DateArchival ?? project.DateArchival,
                CancellationDate = project.CancellationDate,
                NegotiableDeadlineId = (input.NegotiableDeadlineId ?? project.NegotiableDeadlineId).ConvertToInt32(),
                ModuleId = project.ModuleId.ConvertToInt32(),
                Quote = project.Quote,
                DeliveringEmail = project.DeliveringEmail,
                TargetAudienceId = project.TargetAudienceId.ConvertToInt32(),
                ReadershipId = project.ReadershipId.ConvertToInt32(),
                ProductId = project.ProductId.ConvertToInt32(),
                ProductAreaId = project.ProductAreaId.ConvertToInt32(),
                ChargeCodeId = project.ChargeCodeId.ConvertToInt32()
            });
        
        var response = await Client.ExecuteWithErrorHandling<ProjectDto>(updateProjectRequest);

        if (input.IsUrgent == true || project.IsUrgent // need to update separately since put call sets boolean fields to false
            || input.CloseOnDelivery == true || project.CloseOnDelivery
            || input.IsNegotiableDeadline == true || project.IsNegotiableDeadline
            || input.AutomaticArchiving == true || project.AutomaticArchiving 
            || project.IsQuoteRequested)
        {
            var fieldsToUpdate = new FieldValueDto[]
            {
                new(nameof(input.IsUrgent), (input.IsUrgent ?? project.IsUrgent).ToString()),
                new(nameof(input.CloseOnDelivery), (input.CloseOnDelivery ?? project.CloseOnDelivery).ToString()),
                new(nameof(input.IsNegotiableDeadline),
                    (input.IsNegotiableDeadline ?? project.IsNegotiableDeadline).ToString()),
                new(nameof(input.AutomaticArchiving),
                    (input.AutomaticArchiving ?? project.AutomaticArchiving).ToString()),
                new(nameof(project.IsQuoteRequested), project.IsQuoteRequested.ToString())
            };

            var updateFieldsRequest = new FlowFitRequest(
                    $"/api/v1/Projects/{projectIdentifier.ProjectId}/partialupdate", Method.Patch)
                .WithJsonBody(fieldsToUpdate);
            response = await Client.ExecuteWithErrorHandling<ProjectDto>(updateFieldsRequest);
        }
        
        return await ProjectResponse.Create(Client, response);
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
}