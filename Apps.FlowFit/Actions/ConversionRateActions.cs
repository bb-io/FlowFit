using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ConversionRateActions : FlowFitInvocable
{
    public ConversionRateActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the conversion rates", Description = "Returns a list of conversion rates.")]
    public async Task GetConversionRates()
    {
        var request = new FlowFitRequest("/api/v1/ConversionRates", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ConversionRateResult>>(request);
    }

    [Action("Create a new conversion rate", Description = "Creates a new conversion rate and returns the conversion rate result.")]
    public async Task PostConversionRate()
    {
        var request = new FlowFitRequest("/api/v1/ConversionRates", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ConversionRateResult>(request);
    }

    [Action("Get a conversion rate.", Description = "Returns all the details of a conversion rate.")]
    public async Task GetConversionRate()
    {
        var request = new FlowFitRequest("/api/v1/ConversionRates/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ConversionRateResult>(request);
    }

    [Action("Update a conversion rate", Description = "Updates an existing conversion rate and returns the conversion rate result.")]
    public async Task PutConversionRate()
    {
        var request = new FlowFitRequest("/api/v1/ConversionRates/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ConversionRateResult>(request);
    }

    [Action("Delete a conversion rate", Description = "Deletes the given conversion rate.")]
    public async Task DeleteConversionRate()
    {
        var request = new FlowFitRequest("/api/v1/ConversionRates/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}