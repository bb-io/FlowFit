using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers;

public class WorkTypeDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public WorkTypeDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/WorkTypes");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<EntitySimpleDto>>(request);
        var workTypes = response
            .Where(workType => context.SearchString == null 
                               || workType.Description.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(workType => workType.Id, workType => workType.Description);
        return workTypes;
    }
}