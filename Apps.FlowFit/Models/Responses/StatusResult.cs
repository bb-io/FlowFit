using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class StatusResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public int? DisplayOrder { get; set; }
    public bool IsActive { get; set; }
    public string? Color { get; set; }
}