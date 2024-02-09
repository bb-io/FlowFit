using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class UnavailabilityActions : FlowFitInvocable
{
    public UnavailabilityActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all unavailability types.", Description = "Returns a list of all the unavailability types that have been created.")]
    public async Task GetUnavailabilityTypes()
    {
        var request = new FlowFitRequest("/api/v1/UnavailabilityTypes", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<UnavailabilityTypeResult>>(request);
    }

    [Action("Create a new unavailability type", Description = "Creates a new unavailability type and returns the unavailability type result.")]
    public async Task PostUnavailabilityType()
    {
        var request = new FlowFitRequest("/api/v1/UnavailabilityTypes", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<UnavailabilityTypeResult>(request);
    }

    [Action("Get an unavailability type", Description = "Returns all the details of a unavailability type.")]
    public async Task GetUnavailabilityType()
    {
        var request = new FlowFitRequest("/api/v1/UnavailabilityTypes/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<UnavailabilityTypeResult>(request);
    }

    [Action("Update an unavailability type", Description = "Updates an existing unavailability type and returns the unavailability type result.")]
    public async Task PutUnavailabilityType()
    {
        var request = new FlowFitRequest("/api/v1/UnavailabilityTypes/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<UnavailabilityTypeResult>(request);
    }

    [Action("Delete an unavailability type", Description = "Deletes the given unavailability type. Will also delete all related entities.")]
    public async Task DeleteUnavailabilityType()
    {
        var request = new FlowFitRequest("/api/v1/UnavailabilityTypes/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}