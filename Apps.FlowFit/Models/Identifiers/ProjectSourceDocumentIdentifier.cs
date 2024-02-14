using Apps.FlowFit.DataSourceHandlers.Document;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.FlowFit.Models.Identifiers;

public class ProjectSourceDocumentIdentifier
{
    [Display("Source document ID")]
    [DataSource(typeof(ProjectSourceDocumentDataSourceHandler))]
    public string ProjectDocumentId { get; set; }
}