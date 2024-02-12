using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Project;

public class ProjectContactDto 
{
    [Display("Last name")]
    public string? LastName { get; set; }
    
    [Display("Last name")]
    public string? FirstName { get; set; }

    public string? Email { get; set; }
    
    [Display("Project people type ID")]
    public string ProjectPeopleTypeId { get; set; }
    
    public string? Phone { get; set; }
}