using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Language;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers;

public class LanguageDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    public LanguageDataSourceHandler(InvocationContext invocationContext) : base(invocationContext)
    {
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        var request = new FlowFitRequest("/api/v1/Languages");
        var response = await Client.ExecuteWithErrorHandling<IEnumerable<LanguageSimpleDto>>(request);
        var languages = response
            .Where(language => context.SearchString == null 
                               || language.Description.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(language => language.Id, language => language.Description);
        return languages;
    }
}