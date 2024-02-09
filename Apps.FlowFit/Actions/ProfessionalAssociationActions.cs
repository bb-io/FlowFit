using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProfessionalAssociationActions : FlowFitInvocable
{
    public ProfessionalAssociationActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the professional associations", Description = "Returns a list of all the professional associations that have been created.")]
    public async Task GetProfessionalAssociations()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalAssociations", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProfessionalAssociationResult>>(request);
    }

    [Action("Create a new professional association", Description = "Creates a new professional association and returns the professional association results.")]
    public async Task PostProfessionalAssociation()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalAssociations", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProfessionalAssociationResult>(request);
    }

    [Action("Get a professional association", Description = "Returns all the details of a profesionnal association.")]
    public async Task GetProfessionalAssociation()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalAssociations/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProfessionalAssociationResult>(request);
    }

    [Action("Update a professional association", Description = "Updates an existing professional association and returns the professional association result.")]
    public async Task PutProfessionalAssociation()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalAssociations/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProfessionalAssociationResult>(request);
    }

    [Action("Delete a professional association", Description = "Deletes the given professional association. Will also delete all related entities.")]
    public async Task DeleteProfessionalAssociation()
    {
        var request = new FlowFitRequest("/api/v1/ProfessionalAssociations/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}