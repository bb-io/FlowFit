using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ServiceResourceActions : FlowFitInvocable
{
    public ServiceResourceActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all service resources", Description = "Returns a list of all the service resources that have been created.")]
    public async Task GetServiceResources()
    {
        var request = new FlowFitRequest("/api/v1/ServiceResources", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ServiceResourceResult>>(request);
    }

    [Action("Create a new service resource", Description = "Creates a new service resource and returns the service resource result.")]
    public async Task PostServiceResource()
    {
        var request = new FlowFitRequest("/api/v1/ServiceResources", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ServiceResourceResult>(request);
    }

    [Action("Get a service resource", Description = "Returns all the details of a service resource.")]
    public async Task GetServiceResource()
    {
        var request = new FlowFitRequest("/api/v1/ServiceResources/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ServiceResourceResult>(request);
    }

    [Action("Update a service resource", Description = "Updates an existing service resource and returns the service resource result.")]
    public async Task PutServiceResource()
    {
        var request = new FlowFitRequest("/api/v1/ServiceResources/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ServiceResourceResult>(request);
    }

    [Action("Delete a service resource", Description = "Deletes the given service resource. Will also delete all related entities.")]
    public async Task DeleteServiceResource()
    {
        var request = new FlowFitRequest("/api/v1/ServiceResources/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}