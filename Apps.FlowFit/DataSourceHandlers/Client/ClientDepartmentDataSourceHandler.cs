using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos;
using Apps.FlowFit.Models.Identifiers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers.Client;

public class ClientDepartmentDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    private readonly ClientIdentifier _clientIdentifier;
    
    public ClientDepartmentDataSourceHandler(InvocationContext invocationContext, 
        [ActionParameter] ClientIdentifier clientIdentifier) : base(invocationContext)
    {
        _clientIdentifier = clientIdentifier;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (_clientIdentifier.ClientId == null)
            throw new Exception("Please specify client ID first.");
        
        var request = new FlowFitRequest($"/api/v1/ClientDepartments?ClientId={_clientIdentifier.ClientId}");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<EntitySimpleDto>>(request);
        var departments = response
            .Where(department => context.SearchString == null
                                 || department.Description.Contains(context.SearchString,
                                     StringComparison.OrdinalIgnoreCase))
            .OrderByDescending(department => department.Id)
            .ToDictionary(department => department.Id, department => department.Description);
        return departments;
    }
}