using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Client;

public class ClientContactSimpleDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    [Display("First name")]
    public string FirstName { get; set; }
    
    [Display("Last name")]
    public string LastName { get; set; }
    
    public string? Email { get; set; }
    
    [Display("Client ID")]
    public string ClientId { get; set; }
    
    [Display("Client")]
    public string? Client { get; set; }
    
    [Display("Client department ID")]
    public string? ClientDepartmentId { get; set; }
    
    [Display("Client department")]
    public string? ClientDepartment { get; set; }
}