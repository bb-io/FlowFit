using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers;

public class DelayReasonDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public DelayReasonDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/DelayReasons");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<EntitySimpleDto>>(request);
        var reasons = response
            .Where(reason => context.SearchString == null 
                             || reason.Description.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(reason => reason.Id, reason => reason.Description);
        return reasons;
    }
}