using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ClientContactActions : FlowFitInvocable
{
    public ClientContactActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all client contacts", Description = "Returns a list of all the client contacts. Filters can be used to refine the search.")]
    public async Task GetClientContacts()
    {
        var request = new FlowFitRequest("/api/v1/ClientContacts", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ClientContactResult>>(request);
    }

    [Action("Create a new client contact", Description = "Creates a new client contact and returns the client contact result.")]
    public async Task PostClientContact()
    {
        var request = new FlowFitRequest("/api/v1/ClientContacts", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ClientContactResult>(request);
    }

    [Action("Get client contact", Description = "Returns all the details of a client contact.")]
    public async Task GetClientContact()
    {
        var request = new FlowFitRequest("/api/v1/ClientContacts/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ClientContactResult>(request);
    }

    [Action("Update a client contact", Description = "Updates an existing client contact and returns the client contact result.")]
    public async Task PutClientContact()
    {
        var request = new FlowFitRequest("/api/v1/ClientContacts/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ClientContactResult>(request);
    }

    [Action("Patch a client contact", Description = "### Updates partial an existing client contact and returns the client contact result. ###")]
    public async Task PatchClientContact()
    {
        var request = new FlowFitRequest("/api/v1/ClientContacts/{id}", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling<ClientContactResult>(request);
    }

    [Action("Delete a client contact", Description = "Deletes the given client contact. Will also delete all related entities.")]
    public async Task DeleteClientContact()
    {
        var request = new FlowFitRequest("/api/v1/ClientContacts/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}