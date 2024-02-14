using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Project;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers.Project;

public class ProjectStatusDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public ProjectStatusDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/ProjectStatus");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<StatusDto>>(request);
        var statuses = response
            .Where(status => context.SearchString == null 
                             || status.Description.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(status => status.Id, status => status.Description);
        return statuses;
    }
}