using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class ParameterActions : FlowFitInvocable
{
    public ParameterActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the parameters", Description = "Returns a list of all the system parameters.")]
    public async Task GetParams()
    {
        var request = new FlowFitRequest("/api/v1/Params", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ParamResult>>(request);
    }

    [Action("Get a parameter", Description = "Returns all the details of a parameter.")]
    public async Task GetParam()
    {
        var request = new FlowFitRequest("/api/v1/Params/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<ParamResult>(request);
    }

    [Action("Update a parameter", Description = "Updates an existing parameter and returns the paramter result.")]
    public async Task PutParam()
    {
        var request = new FlowFitRequest("/api/v1/Params/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<ParamResult>(request);
    }
}