using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class DomainActions : FlowFitInvocable
{
    public DomainActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get the domains", Description = "Returns a list of all the domains. Filters can be used to refine the search.")]
    public async Task GetDomains()
    {
        var request = new FlowFitRequest("/api/v1/Domains", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<DomainResult>>(request);
    }

    [Action("Create a new domain", Description = "Creates a new domain and returns the domain result.")]
    public async Task PostDomain()
    {
        var request = new FlowFitRequest("/api/v1/Domains", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<DomainResult>(request);
    }

    [Action("Get a domain", Description = "Returns all the details of a domain.")]
    public async Task GetDomain()
    {
        var request = new FlowFitRequest("/api/v1/Domains/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<DomainResult>(request);
    }

    [Action("Update a domain", Description = "Updates an existing domain and returns the domain result.")]
    public async Task PutDomain()
    {
        var request = new FlowFitRequest("/api/v1/Domains/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<DomainResult>(request);
    }

    [Action("Delete a domain", Description = "Deletes the given domain. Will also delete all related entities.")]
    public async Task DeleteDomain()
    {
        var request = new FlowFitRequest("/api/v1/Domains/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}