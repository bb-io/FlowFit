using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Resource;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers;

public class ResourceDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public ResourceDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/Resources");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ResourceSimpleDto>>(request);
        var resources = response
            .Where(resource => context.SearchString == null
                               || resource.FirstName.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase)
                               || resource.LastName.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase)
                               || (resource.Email?.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase) ??
                                   false))
            .ToDictionary(resource => resource.Id,
                resource =>
                    $"{resource.FirstName} {resource.LastName}{(resource.Email != null ? $" <{resource.Email}>" : string.Empty)}");
        return resources;
    }
}