using Apps.FlowFit.DataSourceHandlers;
using Blackbird.Applications.Sdk.Common;
using Blackbird.Applications.Sdk.Common.Dynamic;

namespace Apps.FlowFit.Models.Identifiers;

public class TaskOptionalIdentifier
{
    [Display("Task ID")]
    [DataSource(typeof(TaskDataSourceHandler))]
    public string? TaskId { get; set; }
}