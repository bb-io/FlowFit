using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Task;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Responses.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using Blackbird.Applications.Sdk.Utils.Extensions.Http;
using RestSharp;

namespace Apps.FlowFit.Actions;

[ActionList]
public class TaskActions(InvocationContext invocationContext) : FlowFitInvocable(invocationContext)
{
    #region Get

    [Action("Get task", Description = "Get information about a task.")]
    public async Task<TaskResponse> GetTask([ActionParameter] TaskIdentifier taskIdentifier)
    {
        var request = new FlowFitRequest($"/api/v1/Tasks/{taskIdentifier.TaskId}");
        var task = await Client.ExecuteWithErrorHandling<TaskDto>(request);
        return new(task);
    }

    [Action("Complete task", Description = "Change the status of a task to completed.")]
    public async Task CompleteTask([ActionParameter] TaskIdentifier taskIdentifier, [ActionParameter][Display("Note")] string? note)
    {
        var request = new FlowFitRequest($"/api/v1/Tasks", Method.Post).WithJsonBody(
            new
            {
                taskId = taskIdentifier.TaskId,
                note = note ?? string.Empty
            }
        );
        await Client.ExecuteWithErrorHandling(request);
    }

    #endregion
}