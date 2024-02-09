using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class TimesheetsActions : FlowFitInvocable
{
    public TimesheetsActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all Timesheets by filters", Description = "Returns all tasks filtered by projectId or nothing")]
    public async Task GetTimesheets()
    {
        var request = new FlowFitRequest("/api/v1/Timesheets", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TimesheetSummaryResult>>(request);
    }

    [Action("Get a Timesheet", Description = "Returns all the details of a Timesheet")]
    public async Task GetTimesheet()
    {
        var request = new FlowFitRequest("/api/v1/Timesheets/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TimesheetResult>(request);
    }

    [Action("Get a timesheet items with the filters", Description = "Returns a list of all timesheet items with the filters.")]
    public async Task GetTimesheetItems()
    {
        var request = new FlowFitRequest("/api/v1/Timesheets/GetTimesheetItems", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TimesheetItemResult>>(request);
    }

    [Action("Get a Timesheet item", Description = "Returns all the details of a Timesheet item")]
    public async Task GetTimesheetItem()
    {
        var request = new FlowFitRequest("/api/v1/Timesheets/GetTimesheetItem/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TimesheetItemResult>(request);
    }
}