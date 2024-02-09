using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ResourceActions : FlowFitInvocable
{
    public ResourceActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Search a resources by filters", Description = "Search and returns a list of all the resources by filters.")]
    public async Task Search()
    {
        var request = new FlowFitRequest("/api/v1/Resources/Search", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ResourceListResult>>(request);
    }

    [Action("Get all resources", Description = "Returns a list of all the resources that have been created.")]
    public async Task GetResources()
    {
        var request = new FlowFitRequest("/api/v1/Resources", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ResourceResult>>(request);
    }

    [Action("Get an resource", Description = "Returns all the details of an resource.")]
    public async Task GetResource()
    {
        var request = new FlowFitRequest("/api/v1/Resources/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ResourceResult>(request);
    }
}