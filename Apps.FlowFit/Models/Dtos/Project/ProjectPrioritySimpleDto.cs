using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Project;

public class ProjectPrioritySimpleDto : EntitySimpleDto
{
    public string? Color { get; set; }
    
    [Display("Sort order")]
    public int? SortOrder { get; set; }
}