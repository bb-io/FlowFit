using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class OfficeActions : FlowFitInvocable
{
    public OfficeActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the offices", Description = "Returns a list of all the offices that have been created.")]
    public async Task GetOffices()
    {
        var request = new FlowFitRequest("/api/v1/Offices", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<OfficeResult>>(request);
    }

    [Action("Create a new office", Description = "Creates a new office and returns the office result.")]
    public async Task PostOffice()
    {
        var request = new FlowFitRequest("/api/v1/Offices", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<OfficeResult>(request);
    }

    [Action("Get an office", Description = "Returns all the details of an office.")]
    public async Task GetOffice()
    {
        var request = new FlowFitRequest("/api/v1/Offices/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<OfficeResult>(request);
    }

    [Action("Update an office", Description = "Updates an existing office and returns the office reuslt.")]
    public async Task PutOffice()
    {
        var request = new FlowFitRequest("/api/v1/Offices/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<OfficeResult>(request);
    }

    [Action("Delete an office", Description = "Deletes the given office. Will also delete all related entities.")]
    public async Task DeleteOffice()
    {
        var request = new FlowFitRequest("/api/v1/Offices/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}