using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProjectDocumentActions : FlowFitInvocable
{
    public ProjectDocumentActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get project document", Description = "Returns a project document by its id")]
    public async Task GetProjectDocument()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectDocumentDTO>(request);
    }

    [Action("Get all project documents", Description = "Returns a list of all the project documents that have been created for a given project.")]
    public async Task GetAllProjectDocuments()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/GetAllProjectDocuments", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectDocumentDTO>>(request);
    }

    [Action("Get all project reference documents", Description = "Returns a list of all the project reference documents that have been created for a given project.")]
    public async Task GetProjectReferenceDocuments()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/ReferenceDocuments", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectDocumentReferenceDTO>>(request);
    }

    [Action("Add source document", Description = "Add a source document to the source folder of the project and returns the source document id.")]
    public async Task AddSourceDocument()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/AddSourceDocument", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<int>(request);
    }

    [Action("Add a reference document", Description = "Adds a reference document to a project and return its id.")]
    public async Task AddReferenceDocument()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/AddReferenceDocument", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<int>(request);
    }

    [Action("Add a document", Description = "Adds a document to the given project and return its id.")]
    public async Task AddDocument()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/AddDocument", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<int>(request);
    }

    [Action("Add a document version", Description = "Adds a new document version in the given project.")]
    public async Task AddDocumentVersion()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/AddDocumentVersion", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<int>(request);
    }

    [Action("Replace a source document", Description = "Replace a source document with a new one.")]
    public async Task ReplaceDocument()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/{id}/Replace", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<int>(request);
    }

    [Action("Get the deliverable documents", Description = "Returns a list of the project's deliverable documents that have not been delivered yet.")]
    public async Task DeliverableDocuments()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/{projectId}/DeliverableDocuments", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectDocumentDeliverableResult>(request);
    }

    [Action("Get all  deliverable documents of a project", Description = "Returns a list of the project's deliverable documents.")]
    public async Task AllDeliverableDocuments()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/{projectId}/AllDeliverableDocuments", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectDocumentDeliverableItemResult>>(request);
    }

    [Action("Confirm delivery document", Description = "Confirm the delivery of the documents associated with the given tasks.")]
    public async Task ConfirmDeliveryDocuments()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocuments/{projectId}/ConfirmDeliveryDocuments", Method.Post);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}