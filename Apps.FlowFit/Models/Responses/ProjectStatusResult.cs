using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class ProjectStatusResult 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool? InProgress { get; set; }
    public string? Color { get; set; }
    public bool CanCancel { get; set; }
    public bool CanChangeDeadline { get; set; }
}