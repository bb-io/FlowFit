using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProjectDocumentReferenceTypeActions : FlowFitInvocable
{
    public ProjectDocumentReferenceTypeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the project document reference types", Description = "Get all the project document reference types")]
    public async Task GetProjectDocumentReferenceTypes()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocumentReferenceTypes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectDocumentReferenceTypeResult>>(request);
    }

    [Action("Creat a new project document reference type", Description = "Creates a new project document reference type and returns the project document reference type result.")]
    public async Task PostProjectDocumentReferenceType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocumentReferenceTypes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProjectDocumentReferenceTypeResult>(request);
    }

    [Action("Get project document reference type", Description = "Returns all the details of a project document reference type.")]
    public async Task GetProjectDocumentReferenceType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocumentReferenceTypes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProjectDocumentReferenceTypeResult>(request);
    }

    [Action("Update a project document reference type", Description = "Updates an existing project document reference type and returns the project document reference type result.")]
    public async Task PutProjectDocumentReferenceType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocumentReferenceTypes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProjectDocumentReferenceTypeResult>(request);
    }

    [Action("Delete a project document reference type", Description = "Deletes the given project document reference type. Will also delete all related entities.")]
    public async Task DeleteProjectDocumentReferenceType()
    {
        var request = new FlowFitRequest("/api/v1/ProjectDocumentReferenceTypes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}