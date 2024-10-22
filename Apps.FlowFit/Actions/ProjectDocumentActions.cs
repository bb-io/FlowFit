using System.Net.Mime;
using Apps.FlowFit.Api;
using Apps.FlowFit.Extensions;
using Apps.FlowFit.Models;
using Apps.FlowFit.Models.Dtos.Document;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Requests.Document;
using Apps.FlowFit.Models.Responses.Document;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Files;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.SDK.Extensions.FileManagement.Interfaces;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using RestSharp;

namespace Apps.FlowFit.Actions;

[ActionList]
public class ProjectDocumentActions(InvocationContext invocationContext, IFileManagementClient fileManagementClient)
    : FlowFitInvocable(invocationContext)
{
    #region Get

    [Action("Get source document", Description = "Retrieve information on specified project source document " +
                                                      "and download it.")]
    public async Task<ProjectDocumentResponse> GetProjectDocument(
        [ActionParameter] ProjectIdentifier projectIdentifier, 
        [ActionParameter] ProjectSourceDocumentIdentifier sourceDocumentIdentifier)
    {
        var request = new FlowFitRequest($"/api/v1/ProjectDocuments/{sourceDocumentIdentifier.ProjectDocumentId}");
        var document = await Client.ExecuteWithErrorHandling<ProjectDocumentDto>(request);
        var fileReference = await GetFileReference(document);
        return new(document, fileReference);
    }

    [Action("Download source documents", Description = "Download project source documents.")]
    public async Task<FilesWrapper> DownloadProjectDocuments(
        [ActionParameter] ProjectIdentifier projectIdentifier)
    {
        var files = await DownloadFiles(
            $"/api/v1/ProjectDocuments/GetAllProjectDocuments?projectId={projectIdentifier.ProjectId}");
        return new(files);
    }

    [Action("Download reference documents", Description = "Download project reference documents.")]
    public async Task<FilesWrapper> DownloadProjectReferenceDocuments(
        [ActionParameter] ProjectIdentifier projectIdentifier)
    {
        var files = await DownloadFiles(
            $"/api/v1/ProjectDocuments/ReferenceDocuments?projectId={projectIdentifier.ProjectId}");
        return new(files);
    }
    
    [Action("Download deliverable documents", Description = "Download project deliverable documents. Optionally " +
                                                            "set 'Only undelivered documents' parameter to 'True' " +
                                                            "to download only documents that have not been delivered yet.")]
    public async Task<FilesWrapper> DownloadProjectDeliverableDocuments(
        [ActionParameter] ProjectIdentifier projectIdentifier,
        [ActionParameter] [Display("Only undelivered documents")] bool? onlyUndelivered)
    {
        IEnumerable<FileReference> files;

        if (onlyUndelivered == true)
        {
            var request =
                new FlowFitRequest($"/api/v1/ProjectDocuments/{projectIdentifier.ProjectId}/DeliverableDocuments");
            var response = await Client.ExecuteWithErrorHandling<DeliverableDocumentsWrapper>(request);
            files = await Task.WhenAll(
                response.DeliverableDocuments.Select(async document => await GetFileReference(document)));
        }
        else
            files = await DownloadFiles(
                $"/api/v1/ProjectDocuments/{projectIdentifier.ProjectId}/AllDeliverableDocuments");

        return new(files);
    }
    
    [Action("Upload source document", Description = "Upload a source document to the specified project.")]
    public async Task<UploadProjectDocumentResponse> UploadProjectDocument(
        [ActionParameter] ProjectIdentifier projectIdentifier,
        [ActionParameter] UploadSourceDocumentRequest documentRequest)
    {
        var stream = await fileManagementClient.DownloadAsync(documentRequest.File);
        var memoryStream = new MemoryStream();
        await stream.CopyToAsync(memoryStream);
        memoryStream.Position = 0;
        
        var base64 = await memoryStream.ConvertToBase64String();
        var request = new FlowFitRequest($"/api/v1/ProjectDocuments/AddSourceDocument", Method.Post)
            .WithJsonBody(new
            {
                projectId = projectIdentifier.ProjectId,
                fileName = documentRequest.File.Name,
                fileContent = base64
            });
        
        var document = await Client.ExecuteWithErrorHandling(request);
        return new()
        {
            ProjectDocumentId = document.Content ?? throw new Exception($"Failed to upload project document. Response: {document}")
        };
    }
    
    #endregion
    
    #region Utils

    private async Task<IEnumerable<FileReference>> DownloadFiles(string endpoint)
    {
        var request = new FlowFitRequest(endpoint);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<BaseProjectDocumentDto>>(request);
        var files = await Task.WhenAll(response.Select(async document => await GetFileReference(document)));
        return files;
    }
    
    private async Task<FileReference> GetFileReference(BaseProjectDocumentDto document)
    {
        var filename = Path.GetFileNameWithoutExtension(document.FileName) + document.Extension;
        await using var fileStream = document.FileContent.ConvertFromBase64String();

        if (!MimeTypes.TryGetMimeType(filename, out var contentType))
            contentType = MediaTypeNames.Application.Octet;
            
        var fileReference = await fileManagementClient.UploadAsync(fileStream, contentType, filename);
        return fileReference;
    }
    
    #endregion
}