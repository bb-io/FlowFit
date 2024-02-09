using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProviderPriceDefinitionActions : FlowFitInvocable
{
    public ProviderPriceDefinitionActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the provider price definitions", Description = "Returns a list of all the provider price definition that have been created.")]
    public async Task GetProviderPriceDefinitions()
    {
        var request = new FlowFitRequest("/api/v1/ProviderPriceDefinitions", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProviderPriceDefinitionResult>>(request);
    }

    [Action("Create a new provider price definition", Description = "Creates a new provider price definition and returns the provider price definition result.")]
    public async Task PostProviderPriceDefinition()
    {
        var request = new FlowFitRequest("/api/v1/ProviderPriceDefinitions", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProviderPriceDefinitionResult>(request);
    }

    [Action("Get a provider price definition", Description = "Returns all the details of a provider price definition.")]
    public async Task GetProviderPriceDefinition()
    {
        var request = new FlowFitRequest("/api/v1/ProviderPriceDefinitions/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProviderPriceDefinitionResult>(request);
    }

    [Action("Update the provider price definition", Description = "Update an existing provider price definition and returns the provider price definition result.")]
    public async Task PutProviderPriceDefinition()
    {
        var request = new FlowFitRequest("/api/v1/ProviderPriceDefinitions/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProviderPriceDefinitionResult>(request);
    }

    [Action("Delete a provider price definition", Description = "Deletes the given provider price definition. Will also delete all related entities.")]
    public async Task DeleteProviderPriceDefinition()
    {
        var request = new FlowFitRequest("/api/v1/ProviderPriceDefinitions/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}