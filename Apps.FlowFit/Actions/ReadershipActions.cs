using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ReadershipActions : FlowFitInvocable
{
    public ReadershipActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the readerships", Description = "Returns a list of all the readerships that have been created.")]
    public async Task GetReaderships()
    {
        var request = new FlowFitRequest("/api/v1/Readerships", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ReadershipResult>>(request);
    }

    [Action("Create a new readership", Description = "Creates a new readership and returns the readership result.")]
    public async Task PostReadership()
    {
        var request = new FlowFitRequest("/api/v1/Readerships", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<ReadershipResult>(request);
    }

    [Action("Get a readership", Description = "Returns all the details of a readership.")]
    public async Task GetReadership()
    {
        var request = new FlowFitRequest("/api/v1/Readerships/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ReadershipResult>(request);
    }

    [Action("Update a readership", Description = "Update an existing readership and returns the readership result.")]
    public async Task PutReadership()
    {
        var request = new FlowFitRequest("/api/v1/Readerships/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ReadershipResult>(request);
    }

    [Action("Delete a readership", Description = "Deletes the given readership. Will also delete all related entities.")]
    public async Task DeleteReadership()
    {
        var request = new FlowFitRequest("/api/v1/Readerships/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}