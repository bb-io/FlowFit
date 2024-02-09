using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ProductActions : FlowFitInvocable
{
    public ProductActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get the active products", Description = "Returns a list of all the active products. Filters can be used to refine the search.")]
    public async Task GetProducts()
    {
        var request = new FlowFitRequest("/api/v1/Products", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProductResult>>(request);
    }

    [Action("Create a new product", Description = "Creates a new product and returns the product result.")]
    public async Task PostProduct()
    {
        var request = new FlowFitRequest("/api/v1/Products", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ProductResult>(request);
    }

    [Action("Get a product", Description = "Returns all the details of a product.")]
    public async Task GetProduct()
    {
        var request = new FlowFitRequest("/api/v1/Products/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ProductResult>(request);
    }

    [Action("Update a product", Description = "Updates an existing product and returns the product result.")]
    public async Task PutProduct()
    {
        var request = new FlowFitRequest("/api/v1/Products/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ProductResult>(request);
    }

    [Action("Delete a product", Description = "Deletes the given product. Will also delete all related entities.")]
    public async Task DeleteProduct()
    {
        var request = new FlowFitRequest("/api/v1/Products/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}