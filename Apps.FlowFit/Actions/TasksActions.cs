using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Responses;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Actions;
using Blackbird.Applications.Sdk.Common.Invocation;
using RestSharp;

namespace Apps.FlowFit.Actions;

// [ActionList]
public class TasksActions : FlowFitInvocable
{
    public TasksActions(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    [Action("Get all tasks by project or not", Description = "Returns all tasks filtered by projectId or nothing")]
    public async Task GetTasks()
    {
        var request = new FlowFitRequest("/api/v1/Tasks", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TaskSearchListResult>>(request);
    }

    [Action("Complete a task with file or not", Description = "Complete a task with file or not and returns the result.")]
    public async Task CompleteTask()
    {
        var request = new FlowFitRequest("/api/v1/Tasks", Method.Post);
        var response = await Client.ExecuteWithErrorHandling<bool>(request);
    }

    [Action("Get a task", Description = "Returns all the details of a task")]
    public async Task GetTask()
    {
        var request = new FlowFitRequest("/api/v1/Tasks/{id}", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<TaskResult>(request);
    }

    [Action("Search a task by filters", Description = "Returns a list of all the tasks with the filters.")]
    public async Task Search()
    {
        var request = new FlowFitRequest("/api/v1/Tasks/Search", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TaskSearchListResult>>(request);
    }

    [Action("Get all tasks without filters", Description = "Returns a list of all tasks without filters")]
    public async Task GetAllTasks()
    {
        var request = new FlowFitRequest("/api/v1/Tasks/GetAllTasks", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TaskListResult>>(request);
    }

    [Action("Get Tasks' Additional Documents", Description = "Returns the additional document(s)")]
    public async Task GetTasksAdditionalDocuments()
    {
        var request = new FlowFitRequest("/api/v1/Tasks/GetTasksAdditionalDocuments", Method.Get);
        var response = await Client.ExecuteWithErrorHandling<DownloadFile>(request);
    }
}