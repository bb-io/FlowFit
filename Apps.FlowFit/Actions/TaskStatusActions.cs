using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class TaskStatusActions : FlowFitInvocable
{
    public TaskStatusActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the task Status.", Description = "Returns a list of all the task Status that have been created.")]
    public async Task GetTaskStatusLists()
    {
        var request = new FlowFitRequest("/api/v1/TaskStatus", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TaskStatusResult>>(request);
    }

    [Action("Get a task Status", Description = "Returns all the details of a task Status.")]
    public async Task GetTaskStatus()
    {
        var request = new FlowFitRequest("/api/v1/TaskStatus/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TaskStatusResult>(request);
    }
}