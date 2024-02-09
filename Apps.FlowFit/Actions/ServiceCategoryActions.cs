using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ServiceCategoryActions : FlowFitInvocable
{
    public ServiceCategoryActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the service categories.", Description = "Returns a list of all the service categories that have been created.")]
    public async Task GetServiceCategories()
    {
        var request = new FlowFitRequest("/api/v1/ServiceCategories", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ServiceCategoryResult>>(request);
    }

    [Action("Create a new service category", Description = "Creates a new service category and returns a service category result")]
    public async Task PostServiceCategory()
    {
        var request = new FlowFitRequest("/api/v1/ServiceCategories", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ServiceCategoryResult>(request);
    }

    [Action("Get a service category", Description = "Returns all the details of a service category.")]
    public async Task GetServiceCategory()
    {
        var request = new FlowFitRequest("/api/v1/ServiceCategories/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ServiceCategoryResult>(request);
    }

    [Action("Update a service category", Description = "Updates an existing service category and returns the service cateory result.")]
    public async Task PutServiceCategory()
    {
        var request = new FlowFitRequest("/api/v1/ServiceCategories/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ServiceCategoryResult>(request);
    }

    [Action("Delete a service category", Description = "Deletes the given service category. Will also delete all related entities.")]
    public async Task DeleteServiceCategory()
    {
        var request = new FlowFitRequest("/api/v1/ServiceCategories/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}