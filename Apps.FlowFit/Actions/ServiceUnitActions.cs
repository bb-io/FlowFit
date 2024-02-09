using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ServiceUnitActions : FlowFitInvocable
{
    public ServiceUnitActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the service units", Description = "Returns a list of all the service units that have been created.")]
    public async Task GetServiceUnits()
    {
        var request = new FlowFitRequest("/api/v1/ServiceUnits", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ServiceUnitResult>>(request);
    }

    [Action("Create a new service unit", Description = "Creates a new service unit and returns the service unit result")]
    public async Task PostServiceUnit()
    {
        var request = new FlowFitRequest("/api/v1/ServiceUnits", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ServiceUnitResult>(request);
    }

    [Action("Get a service unit", Description = "Returns all the details of a service unit")]
    public async Task GetServiceUnit()
    {
        var request = new FlowFitRequest("/api/v1/ServiceUnits/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ServiceUnitResult>(request);
    }

    [Action("Update a service unit", Description = "Updates an existing service unit and returns the service unit result")]
    public async Task PutServiceUnit()
    {
        var request = new FlowFitRequest("/api/v1/ServiceUnits/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ServiceUnitResult>(request);
    }

    [Action("Delete a service unit", Description = "Deletes the given service unit. Will also delete all related entities.")]
    public async Task DeleteServiceUnit()
    {
        var request = new FlowFitRequest("/api/v1/ServiceUnits/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}