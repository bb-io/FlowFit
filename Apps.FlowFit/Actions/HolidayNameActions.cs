using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class HolidayNameActions : FlowFitInvocable
{
    public HolidayNameActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the holiday names", Description = "Returns a list of all the holiday names that have been created.")]
    public async Task GetHolidayNames()
    {
        var request = new FlowFitRequest("/api/v1/HolidayNames", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<HolidayNameResult>>(request);
    }

    [Action("Create a new holiday name", Description = "Creates a new holiday name and returns the holiday name result.")]
    public async Task PostHolidayName()
    {
        var request = new FlowFitRequest("/api/v1/HolidayNames", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<HolidayNameResult>(request);
    }

    [Action("Get a holiday name", Description = "Returns all the details of a holiday name.")]
    public async Task GetHolidayName()
    {
        var request = new FlowFitRequest("/api/v1/HolidayNames/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<HolidayNameResult>(request);
    }

    [Action("Update a holiday name", Description = "Updates an existing holiday name and returns the holiday name result.")]
    public async Task PutHolidayName()
    {
        var request = new FlowFitRequest("/api/v1/HolidayNames/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<HolidayNameResult>(request);
    }

    [Action("Delete a holiday name", Description = "Deletes the given holiday name. Will also delete all related entities.")]
    public async Task DeleteHolidayName()
    {
        var request = new FlowFitRequest("/api/v1/HolidayNames/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}