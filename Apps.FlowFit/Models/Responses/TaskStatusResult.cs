using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TaskStatusResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public int? ListDisplayOrder { get; set; }
    public bool IsActive { get; set; }
    public string? Color { get; set; }
}