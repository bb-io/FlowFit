using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Client;
using Apps.FlowFit.Models.Identifiers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers.Client;

public class ClientContactDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    private readonly ClientIdentifier _clientIdentifier;
    
    public ClientContactDataSourceHandler(InvocationContext invocationContext, 
        [ActionParameter] ClientIdentifier clientIdentifier) : base(invocationContext)
    {
        _clientIdentifier = clientIdentifier;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (_clientIdentifier.ClientId == null)
            throw new Exception("Please specify client ID first.");
        
        var request = new FlowFitRequest($"/api/v1/ClientContacts?ClientId={_clientIdentifier.ClientId}");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<ClientContactSimpleDto>>(request);
        var contacts = response
            .Where(contact => context.SearchString == null
                              || contact.FirstName.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase)
                              || contact.LastName.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase)
                              || (contact.Email?.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase) ??
                                  false))
            .OrderByDescending(contact => contact.Id)
            .ToDictionary(contact => contact.Id,
                contact =>
                    $"{contact.FirstName} {contact.LastName}{(contact.Email != null ? $" <{contact.Email}>" : string.Empty)}");
        return contacts;
    }
}