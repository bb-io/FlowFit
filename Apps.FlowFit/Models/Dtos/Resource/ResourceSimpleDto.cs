using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Resource;

public class ResourceSimpleDto 
{
    [Display("ID")]
    public string Id { get; set; }
    
    [Display("Last name")]
    public string LastName { get; set; }
    
    [Display("First name")]
    public string FirstName { get; set; }
    
    public string? Code { get; set; }
    
    [Display("Is internal")]
    public bool? IsInternal { get; set; }
    
    public string? Email { get; set; }
}