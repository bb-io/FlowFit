using Apps.FlowFit.DataSourceHandlers.Project;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.FlowFit.Models.Requests.Project;

public class ProjectStatusRequest
{
    [Display("Status ID")]
    [DataSource(typeof(ProjectStatusDataSourceHandler))]
    public string StatusId { get; set; } = default!;
}