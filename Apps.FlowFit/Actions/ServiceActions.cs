using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ServiceActions : FlowFitInvocable
{
    public ServiceActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the services.", Description = "Returns a list of all the services that have been created.")]
    public async Task GetServices()
    {
        var request = new FlowFitRequest("/api/v1/Services", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ServiceResult>>(request);
    }

    [Action("Create a new service", Description = "Creates a new service and returns the service result.")]
    public async Task PostService()
    {
        var request = new FlowFitRequest("/api/v1/Services", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ServiceResult>(request);
    }

    [Action("Get a service", Description = "Returns all the details of a service.")]
    public async Task GetService()
    {
        var request = new FlowFitRequest("/api/v1/Services/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ServiceResult>(request);
    }

    [Action("Update a service", Description = "Updates an existing service and returns the service result.")]
    public async Task PutService()
    {
        var request = new FlowFitRequest("/api/v1/Services/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ServiceResult>(request);
    }

    [Action("Delete a service", Description = "Deletes the given service. Will also delete all related entities.")]
    public async Task DeleteService()
    {
        var request = new FlowFitRequest("/api/v1/Services/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}