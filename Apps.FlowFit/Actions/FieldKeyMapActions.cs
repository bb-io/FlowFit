using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class FieldKeyMapActions : FlowFitInvocable
{
    public FieldKeyMapActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the field key maps", Description = "Returns a list of all the field key maps that have been created.")]
    public async Task GetFieldKeyMaps()
    {
        var request = new FlowFitRequest("/api/v1/FieldKeyMaps", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<FieldKeyMapResult>>(request);
    }

    [Action("Get a field key map", Description = "Returns all the details of a field key map.")]
    public async Task GetFieldKeyMap()
    {
        var request = new FlowFitRequest("/api/v1/FieldKeyMaps/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<FieldKeyMapResult>(request);
    }
}