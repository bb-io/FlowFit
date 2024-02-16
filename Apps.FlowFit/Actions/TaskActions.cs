using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Task;
using Apps.FlowFit.Models.Identifiers;
using Apps.FlowFit.Models.Responses.Task;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.Actions;

[ActionList]
public class TaskActions : FlowFitInvocable
{
    public TaskActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }
    
    #region Get

    [Action("Get task details", Description = "Get information about a task.")]
    public async Task<TaskResponse> GetTask([ActionParameter] TaskIdentifier taskIdentifier)
    {
        var request = new FlowFitRequest($"/api/v1/Tasks/{taskIdentifier.TaskId}");
        var task = await Client.ExecuteWithErrorHandling<TaskDto>(request);
        return new(task);
    }

    #endregion
}