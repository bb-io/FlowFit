namespace Apps.FlowFit.Models.Dtos.Task;

public class TaskDto
{
    public string Id { get; set; }
    public string ProjectId { get; set; }
    public string ServiceId { get; set; }
    public string StatusId { get; set; }
    public bool IsDeliverable { get; set; }
    public string? LanguageSourceId { get; set; }
    public string? LanguageTargetId { get; set; }
    public TaskAssignee? User { get; set; }
    public DateTime? Deadline { get; set; }
    public string? DocumentPath { get; set; }
    public string? DocumentName { get; set; }
    public string? Instruction { get; set; }
}

public record TaskAssignee(string AssignToClassId);