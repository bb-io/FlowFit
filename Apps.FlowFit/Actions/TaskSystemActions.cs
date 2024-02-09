using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class TaskSystemActions : FlowFitInvocable
{
    public TaskSystemActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all the task systems", Description = "Returns a list of all the task systems that have been created.")]
    public async Task GetTaskSystems()
    {
        var request = new FlowFitRequest("/api/v1/TaskSystems", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TaskSystemResult>>(request);
    }

    [Action("Create a new task system", Description = "Creates a new task system and returns the task system result")]
    public async Task PostTaskSystem()
    {
        var request = new FlowFitRequest("/api/v1/TaskSystems", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<TaskSystemResult>(request);
    }

    [Action("Get a task system", Description = "Returns all the details of a task system.")]
    public async Task GetTaskSystem()
    {
        var request = new FlowFitRequest("/api/v1/TaskSystems/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TaskSystemResult>(request);
    }

    [Action("Update a task system", Description = "Updates an existing task system and returns the task system result")]
    public async Task PutTaskSystem()
    {
        var request = new FlowFitRequest("/api/v1/TaskSystems/{id}", Method.Put);
        var response = await Client.ExecuteWithErrorHandling<TaskSystemResult>(request);
    }

    [Action("Deletes a task system", Description = "Deletes the given task system. Will also delete all related entities.")]
    public async Task DeleteTaskSystem()
    {
        var request = new FlowFitRequest("/api/v1/TaskSystems/{id}", Method.Delete);
        var response = await Client.ExecuteWithErrorHandling(request);
    }
}