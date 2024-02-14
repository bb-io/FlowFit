using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Project;

public class ProjectWorkTypeDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    public string Description { get; set; }
}