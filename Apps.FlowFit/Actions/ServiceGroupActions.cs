using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ServiceGroupActions : FlowFitInvocable
{
    public ServiceGroupActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the service groups", Description = "Returns a list of all the service groups that have been created.")]
    public async Task GetServiceGroups()
    {
        var request = new FlowFitRequest("/api/v1/ServiceGroups", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ServiceGroupResult>>(request);
    }

    [Action("Create a new service group", Description = "Creates a new service group and returns the service group result.")]
    public async Task PostServiceGroup()
    {
        var request = new FlowFitRequest("/api/v1/ServiceGroups", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ServiceGroupResult>(request);
    }

    [Action("Get a service group", Description = "Returns all the details of a service group.")]
    public async Task GetServiceGroup()
    {
        var request = new FlowFitRequest("/api/v1/ServiceGroups/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ServiceGroupResult>(request);
    }

    [Action("Update a service group", Description = "Updates an existing service group and returns the service group result.")]
    public async Task PutServiceGroup()
    {
        var request = new FlowFitRequest("/api/v1/ServiceGroups/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ServiceGroupResult>(request);
    }

    [Action("Delete a service group", Description = "Deletes the given service group. Will also delete all related entities.")]
    public async Task DeleteServiceGroup()
    {
        var request = new FlowFitRequest("/api/v1/ServiceGroups/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}