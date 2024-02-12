using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Project;

public class ProjectPrioritySimpleResponse 
{
    [Display("Project priority ID")]
    public string Id { get; set; }

    public string? Color { get; set; }
    
    [Display("Sort order")]
    public int? SortOrder { get; set; }
    
    public string? Description { get; set; }
}