using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class HolidayActions : FlowFitInvocable
{
    public HolidayActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the holidays", Description = "Returns a list of all the holidays that have been created.")]
    public async Task GetHolidays()
    {
        var request = new FlowFitRequest("/api/v1/Holidays", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<HolidayResult>>(request);
    }

    [Action("Create a new holiday", Description = "Creates a new holiday and returns the holiday result.")]
    public async Task PostHoliday()
    {
        var request = new FlowFitRequest("/api/v1/Holidays", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<HolidayResult>(request);
    }

    [Action("Get a holiday", Description = "Returns all the details of a holiday")]
    public async Task GetHoliday()
    {
        var request = new FlowFitRequest("/api/v1/Holidays/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<HolidayResult>(request);
    }

    [Action("Update a holiday", Description = "Updates an existing holiday and returns the holiday result.")]
    public async Task PutHoliday()
    {
        var request = new FlowFitRequest("/api/v1/Holidays/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<HolidayResult>(request);
    }

    [Action("Delete a holiday", Description = "Deletes the given holiday. Will also delete all related entities.")]
    public async Task DeleteHoliday()
    {
        var request = new FlowFitRequest("/api/v1/Holidays/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}