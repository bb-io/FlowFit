using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Project;

public class StatusDto : EntitySimpleDto
{
    [Display("Display order")]
    public int? DisplayOrder { get; set; }
    
    [Display("Is active")]
    public bool IsActive { get; set; }
    
    public string? Color { get; set; }
}