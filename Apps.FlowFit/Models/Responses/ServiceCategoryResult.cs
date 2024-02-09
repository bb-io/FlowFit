using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ServiceCategoryResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}