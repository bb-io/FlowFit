namespace Apps.FlowFit.Models.Dtos;

public class ProjectChangeDeadlineDTO 
{
    public string RequesterId { get; set; }
    public DateTime? Deadline { get; set; }
    public string DeadlineType { get; set; }
    public string? Comments { get; set; }
}