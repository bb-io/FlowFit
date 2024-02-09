using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProviderInvoicesActions : FlowFitInvocable
{
    public ProviderInvoicesActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all provider invoices by filters", Description = "Returns all provider invoices by filters")]
    public async Task GetProviderInvoices()
    {
        var request = new FlowFitRequest("/api/v1/ProviderInvoices", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProviderInvoiceListResult>>(request);
    }

    [Action("Get a provider invoice", Description = "Returns all the details of a provider invoice")]
    public async Task GetProviderInvoice()
    {
        var request = new FlowFitRequest("/api/v1/ProviderInvoices/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProviderInvoiceResult>(request);
    }

    [Action("Get provider invoice items with the filters", Description = "Returns a list of all provider invoice items with the filters")]
    public async Task GetProviderInvoiceItems()
    {
        var request = new FlowFitRequest("/api/v1/ProviderInvoices/GetProviderInvoiceItems", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProviderInvoiceItemResult>>(request);
    }
}