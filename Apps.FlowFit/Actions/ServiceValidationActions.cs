using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ServiceValidationActions : FlowFitInvocable
{
    public ServiceValidationActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the service validations", Description = "Returns a list of all the service validations that have been created.")]
    public async Task GetServiceValidations()
    {
        var request = new FlowFitRequest("/api/v1/ServiceValidations", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ServiceValidationResult>>(request);
    }

    [Action("Create a new service validation", Description = "Creates a new service validation and returns the service validation result.")]
    public async Task PostServiceValidation()
    {
        var request = new FlowFitRequest("/api/v1/ServiceValidations", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ServiceValidationResult>(request);
    }

    [Action("Get a service validation", Description = "Returns all the details of a service validation.")]
    public async Task GetServiceValidation()
    {
        var request = new FlowFitRequest("/api/v1/ServiceValidations/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ServiceValidationResult>(request);
    }

    [Action("Updates a service validation", Description = "Updates an existing service validation and returns the service validation result.")]
    public async Task PutServiceValidation()
    {
        var request = new FlowFitRequest("/api/v1/ServiceValidations/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ServiceValidationResult>(request);
    }

    [Action("Delete a service validation", Description = "Deletes the given service validation. Will also delete all related entities.")]
    public async Task DeleteServiceValidation()
    {
        var request = new FlowFitRequest("/api/v1/ServiceValidations/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}