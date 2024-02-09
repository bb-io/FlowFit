using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ResourceSimpleResult 
{
    public string Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Code { get; set; }
    public bool IsInternal { get; set; }
    public string? Email { get; set; }
}