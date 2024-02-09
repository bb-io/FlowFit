using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class CurrencyActions : FlowFitInvocable
{
    public CurrencyActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the currencies", Description = "Returns a list of all the currencies that have been created.")]
    public async Task GetCurrencies()
    {
        var request = new FlowFitRequest("/api/v1/Currencies", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<CurrencyResult>>(request);
    }

    [Action("Create a new currency", Description = "Creates a new currency and returns the currency result")]
    public async Task PostCurrency()
    {
        var request = new FlowFitRequest("/api/v1/Currencies", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<CurrencyResult>(request);
    }

    [Action("Get a currency", Description = "Returns all the details of a currency.")]
    public async Task GetCurrency()
    {
        var request = new FlowFitRequest("/api/v1/Currencies/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<CurrencyResult>(request);
    }

    [Action("Update a currency", Description = "Updates an existing currency and returns the currency result.")]
    public async Task PutCurrency()
    {
        var request = new FlowFitRequest("/api/v1/Currencies/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<CurrencyResult>(request);
    }

    [Action("Delete a currency", Description = "Deletes the given currency.")]
    public async Task DeleteCurrency()
    {
        var request = new FlowFitRequest("/api/v1/Currencies/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}