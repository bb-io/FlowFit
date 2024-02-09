using Apps.FlowFit.Models.Dtos;

namespace Apps.FlowFit.Models.Responses;

public class TaskListResult 
{
    public string Id { get; set; }
    public string WorkflowId { get; set; }
    public string ServiceId { get; set; }
    public string? AssignToClassName { get; set; }
    public string AssignToClassId { get; set; }
    public string TaskStatusId { get; set; }
    public string LanguageSourceId { get; set; }
    public string LanguageTargetId { get; set; }
    public decimal? EstimatedTime { get; set; }
    public DateTime? AssignedDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? Deadline { get; set; }
    public DateTime? ReadyDate { get; set; }
    public string UnitId { get; set; }
    public decimal? Quantity { get; set; }
}