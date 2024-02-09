using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class DynamicLabelActions : FlowFitInvocable
{
    public DynamicLabelActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the dynamic labels.", Description = "Returns a list of all the dynamic labels that have been created.")]
    public async Task GetDynamicLabels()
    {
        var request = new FlowFitRequest("/api/v1/DynamicLabels", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<FieldKeyMapValueResult>>(request);
    }

    [Action("Create a new dynamic label", Description = "Creates a new dynamic label and returns the dynamic label result.")]
    public async Task PostDynamicLabel()
    {
        var request = new FlowFitRequest("/api/v1/DynamicLabels", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<FieldKeyMapValueResult>(request);
    }

    [Action("Get a dynamic label.", Description = "Returns all the details of a dynamic label.")]
    public async Task GetDynamicLabel()
    {
        var request = new FlowFitRequest("/api/v1/DynamicLabels/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<FieldKeyMapValueResult>(request);
    }

    [Action("Update a dynamic label", Description = "Updates an existing dynamic label and returns the dynamic label result.")]
    public async Task PutDynamicLabel()
    {
        var request = new FlowFitRequest("/api/v1/DynamicLabels/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<FieldKeyMapValueResult>(request);
    }

    [Action("Delete a dynamic label", Description = "Deletes the given dynamic label. Will also delete all related entities.")]
    public async Task DeleteDynamicLabel()
    {
        var request = new FlowFitRequest("/api/v1/DynamicLabels/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}