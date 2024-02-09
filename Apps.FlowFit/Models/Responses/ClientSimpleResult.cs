using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ClientSimpleResult 
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? Code { get; set; }
    public string ClientGroupId { get; set; }
    public string? ClientGroup { get; set; }
}