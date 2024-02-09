using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ContactTypeActions : FlowFitInvocable
{
    public ContactTypeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get the contact types", Description = "Returns a list of contact types that have been created.")]
    public async Task GetContactTypes()
    {
        var request = new FlowFitRequest("/api/v1/ContactTypes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ContactTypeResult>>(request);
    }

    [Action("Create a new contact type", Description = "Create a new contact type and returns the contact type result.")]
    public async Task PostContactType()
    {
        var request = new FlowFitRequest("/api/v1/ContactTypes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ContactTypeResult>(request);
    }

    [Action("Get a contact type", Description = "Returns all the details of a contact type.")]
    public async Task GetContactType()
    {
        var request = new FlowFitRequest("/api/v1/ContactTypes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ContactTypeResult>(request);
    }

    [Action("Update a contact type", Description = "Updates an existing contact type and returns the contact type result")]
    public async Task PutContactType()
    {
        var request = new FlowFitRequest("/api/v1/ContactTypes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ContactTypeResult>(request);
    }

    [Action("Delete a contact types", Description = "Deletes the given contact type.")]
    public async Task DeleteContactType()
    {
        var request = new FlowFitRequest("/api/v1/ContactTypes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}