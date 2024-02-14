using Apps.FlowFit.Api;
using Apps.FlowFit.Models.Dtos.Document;
using Apps.FlowFit.Models.Dtos.Project;
using Apps.FlowFit.Models.Identifiers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;
using Blackbird.Applications.Sdk.Common.Invocation;

namespace Apps.FlowFit.DataSourceHandlers.Document;

public class ProjectSourceDocumentDataSourceHandler : FlowFitInvocable, IAsyncDataSourceHandler
{
    private readonly ProjectIdentifier _projectIdentifier;
    
    public ProjectSourceDocumentDataSourceHandler(InvocationContext invocationContext, 
        [ActionParameter] ProjectIdentifier projectIdentifier) : base(invocationContext)
    {
        _projectIdentifier = projectIdentifier;
    }

    public async Task<Dictionary<string, string>> GetDataAsync(DataSourceContext context,
        CancellationToken cancellationToken)
    {
        if (_projectIdentifier.ProjectId == null)
            throw new Exception("Please specify project ID first.");

        var request = new FlowFitRequest($"/api/v1/Projects/{_projectIdentifier.ProjectId}");
        var project = await Client.ExecuteWithErrorHandling<ProjectDto>(request);
        var documents = (project.ProjectSourceDocuments ?? Enumerable.Empty<DocumentSimpleDto>())
            .Where(document => context.SearchString == null
                               || document.FileName.Contains(context.SearchString, StringComparison.OrdinalIgnoreCase))
            .ToDictionary(document => document.Id, document => document.FileName);
        return documents;
    }
}