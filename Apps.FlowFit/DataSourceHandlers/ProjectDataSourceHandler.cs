using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Project;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers;

public class ProjectDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public ProjectDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/Projects");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ProjectDto>>(request);
        var projects = response
            .Where(project => context.SearchString == null 
                          || project.Title.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(project => project.CreationDate)
            .Take(20)
            .ToDictionary(project => project.Id, project => project.Title);
        return projects;
    }
}