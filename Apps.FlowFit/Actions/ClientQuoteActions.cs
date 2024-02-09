using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ClientQuoteActions : FlowFitInvocable
{
    public ClientQuoteActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all client quotes", Description = "Returns a list of client quotes. Filters can be used to refine the search.")]
    public async Task GetClientQuotes()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ClientQuoteResult>>(request);
    }

    [Action("Create a new client quote", Description = "Create a new client quote")]
    public async Task ClientQuotes()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ClientQuoteResult>(request);
    }

    [Action("Get a client quote", Description = "Returns all the details of a client quote.")]
    public async Task GetClientQuote()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ClientQuoteResult>(request);
    }

    [Action("Update a client quote", Description = "Update a client quote")]
    public async Task PutClientQuote()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ClientQuoteResult>(request);
    }

    [Action("Delete a client quote", Description = "Delete a client quote")]
    public async Task DeleteClientQuote()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }

    [Action("Create pre filled data client quote", Description = "Create pre filled data client quote")]
    public async Task PostPreFilledClientQuote()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes/{projectId}", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ClientQuoteResult>(request);
    }

    [Action("Accept a quote", Description = "Accept a quote")]
    public async Task AcceptQuote()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes/{clientQuoteId}/acceptquote", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling<bool>(request);
    }

    [Action("Refuse a quote", Description = "Refuse a quote")]
    public async Task RefuseQuote()
    {
        var request = new FlowFitRequest("/api/v1/ClientQuotes/{clientQuoteId}/refusequote", Method.Patch);
        var response = await Client.ExecuteWithErrorHandling<bool>(request);
    }
}