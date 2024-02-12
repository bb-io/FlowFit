using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Project;

public class StatusResponse 
{
    [Display("Status ID")]
    public string Id { get; set; }

    public string Description { get; set; }
    
    [Display("Display order")]
    public int? DisplayOrder { get; set; }
    
    [Display("Is active")]
    public bool IsActive { get; set; }
    
    public string? Color { get; set; }
}