using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Task;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers;

public class TaskDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public TaskDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/Tasks");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<TaskListDto>>(request);
        var tasks = response
            .Where(task => context.SearchString == null
                           || task.ServiceDescription.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase)
                           || task.Id.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase)
                           || task.ProjectNumber.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase)
                           || task.ProjectTitle.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(task => task.Id)
            .Take(30)
            .ToDictionary(task => task.Id,
                task => $"{task.Id}: {task.ServiceDescription} ({task.ProjectTitle})");
        return tasks;
    }
}