using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class TimeZoneActions : FlowFitInvocable
{
    public TimeZoneActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the system timezones", Description = "The time zone Id should be used in the authentication token.")]
    public async Task GetTimeZones()
    {
        var request = new FlowFitRequest("/api/v1/TimeZone", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TimeZoneResult>>(request);
    }
}