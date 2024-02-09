using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProviderInvoiceStatusActions : FlowFitInvocable
{
    public ProviderInvoiceStatusActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the Provider invoice status", Description = "Returns a lit of all the Provider invoice status that have been created.")]
    public async Task GetProviderInvoiceStatus()
    {
        var request = new FlowFitRequest("/api/v1/ProviderInvoiceStatus", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProviderInvoiceStatusResult>(request);
    }

    [Action("Get a Provider invoice status", Description = "Returns all the details of a Provider invoice status.")]
    public async Task GetProviderInvoiceStatusById()
    {
        var request = new FlowFitRequest("/api/v1/ProviderInvoiceStatus/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProviderInvoiceStatusResult>(request);
    }
}