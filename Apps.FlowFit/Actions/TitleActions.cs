using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class TitleActions : FlowFitInvocable
{
    public TitleActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the titles", Description = "Returns a list of all the titles that have been created.")]
    public async Task GetTitles()
    {
        var request = new FlowFitRequest("/api/v1/Titles", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TitleResult>>(request);
    }

    [Action("Create a new title", Description = "Creates a new title and returns the title result.")]
    public async Task PostTitle()
    {
        var request = new FlowFitRequest("/api/v1/Titles", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<TitleResult>(request);
    }

    [Action("Get a title", Description = "Returns all the details of a title.")]
    public async Task GetTitle()
    {
        var request = new FlowFitRequest("/api/v1/Titles/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TitleResult>(request);
    }

    [Action("Update a title", Description = "Updates an existing title and returns the title result.")]
    public async Task PutTitle()
    {
        var request = new FlowFitRequest("/api/v1/Titles/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<TitleResult>(request);
    }

    [Action("Delete a title", Description = "Deletes the given title. Will also delete all related entities.")]
    public async Task DeleteTitle()
    {
        var request = new FlowFitRequest("/api/v1/Titles/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}