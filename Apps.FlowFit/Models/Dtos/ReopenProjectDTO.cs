namespace Apps.FlowFit.Models.Dtos;

public class ReopenProjectDTO 
{
    public string RequesterId { get; set; }
    public DateTime? Deadline { get; set; }
    public string? Comments { get; set; }
}