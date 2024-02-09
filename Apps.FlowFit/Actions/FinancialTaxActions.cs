using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class FinancialTaxActions : FlowFitInvocable
{
    public FinancialTaxActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the financial taxes", Description = "Returns a list of all the financial taxes that have been created.")]
    public async Task GetFinancialTaxes()
    {
        var request = new FlowFitRequest("/api/v1/FinancialTaxes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TaxExtendedResult>>(request);
    }

    [Action("Create a new financial tax", Description = "Creates a new financial tax and returns the financial tax result.")]
    public async Task PostFinancialTax()
    {
        var request = new FlowFitRequest("/api/v1/FinancialTaxes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<FinancialTaxResult>(request);
    }

    [Action("Get a financial tax", Description = "Returns all the details of a financial tax")]
    public async Task GetFinancialTax()
    {
        var request = new FlowFitRequest("/api/v1/FinancialTaxes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TaxExtendedResult>(request);
    }

    [Action("Update a financial tax.", Description = "Updates an existing financial tax and returns the financial tax result.")]
    public async Task PutFinancialTax()
    {
        var request = new FlowFitRequest("/api/v1/FinancialTaxes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<FinancialTaxResult>(request);
    }

    [Action("Delete a financial tax", Description = "Deletes the given financial tax.")]
    public async Task DeleteFinancialTax()
    {
        var request = new FlowFitRequest("/api/v1/FinancialTaxes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}