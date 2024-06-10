using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Project;

public class StatusDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    public string Description { get; set; }
    
    [Display("Is active")]
    public bool IsActive { get; set; }
}