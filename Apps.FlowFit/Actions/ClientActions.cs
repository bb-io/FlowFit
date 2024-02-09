using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ClientActions : FlowFitInvocable
{
    public ClientActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all clients", Description = "Returns a list of clients. Filters can be used to refine the search.")]
    public async Task GetClients()
    {
        var request = new FlowFitRequest("/api/v1/Clients", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ClientResult>>(request);
    }

    [Action("Create a new client", Description = "Creates a new client and returns the client result.")]
    public async Task PostClient()
    {
        var request = new FlowFitRequest("/api/v1/Clients", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ClientResult>(request);
    }

    [Action("Get a client", Description = "Returns all the details of a client.")]
    public async Task GetClient()
    {
        var request = new FlowFitRequest("/api/v1/Clients/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ClientResult>(request);
    }

    [Action("Update a client", Description = "Updates an existing client and returns the client result.")]
    public async Task PutClient()
    {
        var request = new FlowFitRequest("/api/v1/Clients/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ClientResult>(request);
    }

    [Action("Patch a Client", Description = "### Updates partial an existing client and returns the client result. ###")]
    public async Task PatchClient()
    {
        var request = new FlowFitRequest("/api/v1/Clients/{id}", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling<ClientResult>(request);
    }

    [Action("Delete a client", Description = "Deletes the given client. Will also delete all related entities.")]
    public async Task DeleteClient()
    {
        var request = new FlowFitRequest("/api/v1/Clients/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling<bool>(request);
    }
}