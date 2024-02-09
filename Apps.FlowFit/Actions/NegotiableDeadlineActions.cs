using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class NegotiableDeadlineActions : FlowFitInvocable
{
    public NegotiableDeadlineActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the negotiable deadlines", Description = "Returns a list of all the negotiable deadlines that have been created.")]
    public async Task GetNegotiableDeadlines()
    {
        var request = new FlowFitRequest("/api/v1/NegotiableDeadlines", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<NegotiableDeadlineResult>>(request);
    }

    [Action("Create a new negotiable deadline", Description = "Creates a new negotiable dealine and returns the negotiable deadline result.")]
    public async Task PostNegotiableDeadline()
    {
        var request = new FlowFitRequest("/api/v1/NegotiableDeadlines", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<NegotiableDeadlineResult>(request);
    }

    [Action("Get a negotiable deadline", Description = "Returns all the details of a negotiable deadline.")]
    public async Task GetNegotiableDeadline()
    {
        var request = new FlowFitRequest("/api/v1/NegotiableDeadlines/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<NegotiableDeadlineResult>(request);
    }

    [Action("Update a negotiable deadline", Description = "Updates an existing negotiable deadline and returns the negotiable deadline result")]
    public async Task PutNegotiableDeadline()
    {
        var request = new FlowFitRequest("/api/v1/NegotiableDeadlines/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<NegotiableDeadlineResult>(request);
    }

    [Action("Delete a negotiable deadline", Description = "Deletes the given negotiable deadline. Will also delete all related entities.")]
    public async Task DeleteNegotiableDeadline()
    {
        var request = new FlowFitRequest("/api/v1/NegotiableDeadlines/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}