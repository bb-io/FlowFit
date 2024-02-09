using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class CountryActions : FlowFitInvocable
{
    public CountryActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the countries", Description = "Returns a list of countries that have been created.")]
    public async Task GetCountries()
    {
        var request = new FlowFitRequest("/api/v1/Countries", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<CountryResult>>(request);
    }

    [Action("Create a new country", Description = "Creates a new country and returns the country result.")]
    public async Task PostCountry()
    {
        var request = new FlowFitRequest("/api/v1/Countries", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<CountryResult>(request);
    }

    [Action("Get a country", Description = "Returns all the details of a country.")]
    public async Task GetCountry()
    {
        var request = new FlowFitRequest("/api/v1/Countries/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<CountryResult>(request);
    }

    [Action("Update a country", Description = "Updates an existing country and returns the country result.")]
    public async Task PutCountry()
    {
        var request = new FlowFitRequest("/api/v1/Countries/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<CountryResult>(request);
    }

    [Action("Delete a country", Description = "Deletes the given country. Will also delete all related entities.")]
    public async Task DeleteCountry()
    {
        var request = new FlowFitRequest("/api/v1/Countries/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}