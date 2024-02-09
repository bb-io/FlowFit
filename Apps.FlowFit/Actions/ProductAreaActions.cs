using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProductAreaActions : FlowFitInvocable
{
    public ProductAreaActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the product areas", Description = "Returns a list of all the product areas that have been created.")]
    public async Task GetProductAreas()
    {
        var request = new FlowFitRequest("/api/v1/ProductAreas", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProductAreaResult>>(request);
    }

    [Action("Create a new product area", Description = "Creates a new product area and returns the product area result.")]
    public async Task PostProductArea()
    {
        var request = new FlowFitRequest("/api/v1/ProductAreas", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProductAreaResult>(request);
    }

    [Action("Get product area", Description = "Returns all the details of a product area.")]
    public async Task GetProductArea()
    {
        var request = new FlowFitRequest("/api/v1/ProductAreas/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProductAreaResult>(request);
    }

    [Action("Update a product area", Description = "Updates an existing product area and returns the product area result.")]
    public async Task PutProductArea()
    {
        var request = new FlowFitRequest("/api/v1/ProductAreas/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProductAreaResult>(request);
    }

    [Action("Delete a product area", Description = "Deletes the given product area. Will also delete all related entities.")]
    public async Task DeleteProductArea()
    {
        var request = new FlowFitRequest("/api/v1/ProductAreas/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}