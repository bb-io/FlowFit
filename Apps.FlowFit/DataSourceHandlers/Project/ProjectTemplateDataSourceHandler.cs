using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers.Project;

public class ProjectTemplateDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public ProjectTemplateDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/ProjectTemplates");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<EntitySimpleDto>>(request);
        var templates = response
            .Where(template => context.SearchString == null 
                               || template.Description.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(template => template.Id, template => template.Description);
        return templates;
    }
}