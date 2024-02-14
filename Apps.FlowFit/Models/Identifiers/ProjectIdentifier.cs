using Apps.FlowFit.DataSourceHandlers.Project;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.FlowFit.Models.Identifiers;

public class ProjectIdentifier
{
    [Display("Project ID")]
    [DataSource(typeof(ProjectDataSourceHandler))]
    public string ProjectId { get; set; }
}