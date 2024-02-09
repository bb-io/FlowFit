using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ClientContactTypeActions : FlowFitInvocable
{
    public ClientContactTypeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all client contact types", Description = "Returns a list of all the client contact types that have been created.")]
    public async Task GetClientContactTypes()
    {
        var request = new FlowFitRequest("/api/v1/ClientContactTypes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ClientContactTypeResult>>(request);
    }

    [Action("Create a new client contact type", Description = "Creates a new client contact type and returns the client contact type result.")]
    public async Task PostClientContactType()
    {
        var request = new FlowFitRequest("/api/v1/ClientContactTypes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ClientContactTypeResult>(request);
    }

    [Action("Get a client contact type", Description = "Returns all the details of a client contact type.")]
    public async Task GetClientContactType()
    {
        var request = new FlowFitRequest("/api/v1/ClientContactTypes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ClientContactTypeResult>(request);
    }

    [Action("Update a client contact type", Description = "Updates an existing client contact type and returns the client contact type result.")]
    public async Task PutClientContactType()
    {
        var request = new FlowFitRequest("/api/v1/ClientContactTypes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ClientContactTypeResult>(request);
    }

    [Action("Delete a client contact type", Description = "Deletes the given client contact type. Will also delete all related entities.")]
    public async Task DeleteClientContactType()
    {
        var request = new FlowFitRequest("/api/v1/ClientContactTypes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}