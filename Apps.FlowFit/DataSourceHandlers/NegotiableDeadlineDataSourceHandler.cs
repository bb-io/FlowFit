using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers;

public class NegotiableDeadlineDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public NegotiableDeadlineDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/NegotiableDeadlines");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<EntitySimpleDto>>(request);
        var deadlines = response
            .Where(deadline => context.SearchString == null 
                               || deadline.Description.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(deadline => deadline.Id, deadline => deadline.Description);
        return deadlines;
    }
}