using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Client;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers.Client;

public class ClientDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public ClientDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/Clients");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ClientDto>>(request);
        var clients = response
            .Where(client => context.SearchString == null 
                              || client.Name.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(client => client.LastProjectCreatedDate)
            .Take(20)
            .ToDictionary(client => client.Id, client => client.Name);
        return clients;
    }
}