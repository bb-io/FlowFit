using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Dtos.Client;

public class ClientDepartmentDto
{
    [Display("ID")]
    public string Id { get; set; }
    
    public string Description { get; set; }
}