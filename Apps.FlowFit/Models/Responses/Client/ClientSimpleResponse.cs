using Blackbird.Applications.Sdk.Common;

namespace Apps.FlowFit.Models.Responses.Client;

public class ClientSimpleResponse 
{
    [Display("Client ID")]
    public string Id { get; set; }

    public string Name { get; set; } 
    
    public string? Code { get; set; }
    
    [Display("Client group ID")]
    public string ClientGroupId { get; set; }
    
    [Display("Client group")]
    public string? ClientGroup { get; set; }
}