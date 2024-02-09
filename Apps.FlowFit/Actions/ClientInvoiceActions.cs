using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ClientInvoiceActions : FlowFitInvocable
{
    public ClientInvoiceActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all client invoices", Description = "Returns a list of client invoices. Filters can be used to refine the search.")]
    public async Task GetClientInvoices()
    {
        var request = new FlowFitRequest("/api/v1/ClientInvoices", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ClientInvoicesListResult>(request);
    }

    [Action("Create a new client invoice", Description = "Create a new client invoice")]
    public async Task ClientInvoices()
    {
        var request = new FlowFitRequest("/api/v1/ClientInvoices", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ClientInvoiceResult>(request);
    }

    [Action("Get a client invoice", Description = "Returns all the details of a client invoice.")]
    public async Task GetClientInvoice()
    {
        var request = new FlowFitRequest("/api/v1/ClientInvoices/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ClientInvoiceResult>(request);
    }

    [Action("Update a client invoice", Description = "Update a client invoice")]
    public async Task PutClientInvoice()
    {
        var request = new FlowFitRequest("/api/v1/ClientInvoices/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ClientInvoiceResult>(request);
    }

    [Action("Delete a client invoice", Description = "Delete a client invoice")]
    public async Task DeleteClientInvoice()
    {
        var request = new FlowFitRequest("/api/v1/ClientInvoices/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}