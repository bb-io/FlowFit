namespace Apps.FlowFit.Models.Dtos;

public class ProjectStatusDTO 
{
    public string Id { get; set; }
    public string? Description { get; set; }
    public bool? InProgress { get; set; }
    public string? Color { get; set; }
    public bool CanCancel { get; set; }
    public bool CanChangeDeadline { get; set; }
}