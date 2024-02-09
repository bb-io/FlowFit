using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProviderProfileActions : FlowFitInvocable
{
    public ProviderProfileActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the provider profiles", Description = "Returns a list of all the profiles that have been created.")]
    public async Task GetProviderProfiles()
    {
        var request = new FlowFitRequest("/api/v1/ProviderProfiles", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProviderProfileResult>>(request);
    }

    [Action("Create a new provider profile", Description = "Creates a new provider profile and returns the provider profile result.")]
    public async Task PostProviderProfile()
    {
        var request = new FlowFitRequest("/api/v1/ProviderProfiles", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProviderProfileResult>(request);
    }

    [Action("Get provider profile", Description = "Returns all the details of a provider profile.")]
    public async Task GetProviderProfile()
    {
        var request = new FlowFitRequest("/api/v1/ProviderProfiles/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProviderProfileResult>(request);
    }

    [Action("Update a provider profile", Description = "Updates an existing provider profile and returns the provider profile result.")]
    public async Task PutProviderProfile()
    {
        var request = new FlowFitRequest("/api/v1/ProviderProfiles/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling(request);
    }

    [Action("Delete a provider profile", Description = "Deletes the given provider profile. Will also delete all related entities.")]
    public async Task DeleteProviderProfile()
    {
        var request = new FlowFitRequest("/api/v1/ProviderProfiles/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}